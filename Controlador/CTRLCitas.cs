using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DAO;
using Empresa_laboral_ADNE___Proyecto_PTC.Modelo.DTO;
using Empresa_laboral_ADNE___Proyecto_PTC.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace Empresa_laboral_ADNE___Proyecto_PTC.Controlador
{
    internal class CTRLCitas
    {
        readonly frmCitas objCitasForm;
        readonly ControlPacientePlanillaUC objUC;
        public CTRLCitas(frmCitas Vista)
        {
            objCitasForm = Vista;

            objCitasForm.Load += new EventHandler(CargarCitas);
            objCitasForm.txtBuscarCita.KeyPress += new KeyPressEventHandler(BuscarCitas);
        }
        public CTRLCitas(ControlPacientePlanillaUC Vista)
        {
            objUC = Vista;

            objUC.btnDescargar.Click += new EventHandler(Cargar_info_Paciente);
        }
        public void CargarCitas(object sender, EventArgs e)
        {
            DAOCitas objCitaUC = new DAOCitas();
            DataTable dt = objCitaUC.Cargar();

            foreach (DataRow dr in dt.Rows)
            {
                objCitaUC.CitaId = (int)dr[0];
                objCitaUC.PacienteId = (int)dr[1];
                objCitaUC.N_expediente = (int)dr[2];
                objCitaUC.EstadoId = (string)dr[3];
                objCitaUC.Nombre = (string)dr[4];
                objCitaUC.Fecha = (DateTime)dr[5];
                objCitaUC.HoraInicio = (TimeSpan)dr[6];

                ControlPacientePlanillaUC PanelPaciente = new ControlPacientePlanillaUC(objCitaUC);
                objCitasForm.flpCitas.Controls.Add(PanelPaciente);
            }
        }
        public void BuscarCitas(object sender, KeyPressEventArgs e)
        {
            DAOCitas objCitas = new DAOCitas();
            DataSet ds = objCitas.BuscarCita(objCitasForm.txtBuscarCita.Text.Trim());

            objCitasForm.flpCitas.Controls.Clear();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                objCitas.Nombre = (string)dr[1];
                objCitas.Fecha = (DateTime)dr[2];
                objCitas.HoraInicio = (TimeSpan)dr[3];
                objCitas.EstadoId = (string)dr[4];

                ControlPacientePlanillaUC PanelPaciente = new ControlPacientePlanillaUC(objCitas);
                objCitasForm.flpCitas.Controls.Add(PanelPaciente);
            }
        }
        public void Cargar_info_Paciente(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = DateTime.Now.ToString("ddMMyyyy") + ".pdf";

                DAOCitas objCitasDAO = new DAOCitas();
                objCitasDAO.PacienteId = int.Parse(objUC.lblPacienteId.Text);
                objCitasDAO.CitaId = int.Parse(objUC.lblCitaId.Text);
                objCitasDAO.N_expediente = int.Parse(objUC.lblExpedienteId.Text);

                if (objCitasDAO.Obtener_expediente_Informacion() == true)
                {
                    string pag = Properties.Resources.Expediente__Psicosocial.ToString();

                    #region
                    pag = pag.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                    pag = pag.Replace("@EXPEDIENTEID", objCitasDAO.N_expediente.ToString());
                    //Remplazando en el documento los Datos de identificación
                    pag = pag.Replace("@NOMBRECOMPLETO", objCitasDAO.Nombre_apellido_paciente);
                    pag = pag.Replace("@NACIONALIDAD", objCitasDAO.Nacionalidad);
                    pag = pag.Replace("@DOCUMENTOPRESENTADO", objCitasDAO.Doc_presentado);
                    pag = pag.Replace("@PROFESION", objCitasDAO.Profesion);
                    pag = pag.Replace("@EDAD", objCitasDAO.Edad.ToString());
                    pag = pag.Replace("@GENERO", objCitasDAO.Genero);
                    pag = pag.Replace("@TELEFONO", objCitasDAO.Tel);
                    pag = pag.Replace("@COMPOSICIONFAMILIAR", objCitasDAO.Com_familiar);
                    pag = pag.Replace("@MOTIVO", objCitasDAO.Motivo);
                    pag = pag.Replace("@ANTECEDENTE", objCitasDAO.Antecedentes);
                    pag = pag.Replace("@DESCRIPCIONSITUACION", objCitasDAO.Desc_situacion);
                    pag = pag.Replace("@ASPECTOSPREOCUPANTES", objCitasDAO.Aspectos);
                    //Remplazando datos del Impacto psicosocial
                    pag = pag.Replace("@ESTADOANIMO", objCitasDAO.Afectividad);
                    pag = pag.Replace("@ESTADOCONDUCTUAL", objCitasDAO.Estado_conducta);
                    pag = pag.Replace("@SOMATIZACION", objCitasDAO.Somatizaciones);
                    pag = pag.Replace("@VIDAINTERPERSONAL", objCitasDAO.VidaInterpersonal);
                    pag = pag.Replace("@COGNICION", objCitasDAO.Cognicion);
                    pag = pag.Replace("@REDSOCIAL", objCitasDAO.Red_social);
                    pag = pag.Replace("@PAUTA", objCitasDAO.Pautas);
                    pag = pag.Replace("@RIESGOVALORADO", objCitasDAO.RiesgoValorado);
                    //Observaciones generales
                    pag = pag.Replace("@OBSERVACION", objCitasDAO.Observacion);
                    //Aproximaciones diagnósticas
                    pag = pag.Replace("@APROXIMACIONDIAG", objCitasDAO.AproximacionDiag);
                    //Atención brindada del paciente agregada al doc
                    pag = pag.Replace("@ATENCIONBRINDADA", objCitasDAO.AtencionBrindada);
                    //Información de las sesiones de seguimiento
                    pag = pag.Replace("@FECHA_C", objCitasDAO.Fecha_Cita.ToString());
                    pag = pag.Replace("@HORAINICIO", objCitasDAO.HoraInicio.ToString());
                    pag = pag.Replace("@LUGAR", objCitasDAO.Lugar);
                    pag = pag.Replace("@DESCRIPCION", objCitasDAO.Desc_Cita);
                    #endregion

                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(new Phrase(""));

                            using (StringReader sr = new StringReader(pag))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }

                            pdfDoc.Close();
                            stream.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para el paciente seleccionado.", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}