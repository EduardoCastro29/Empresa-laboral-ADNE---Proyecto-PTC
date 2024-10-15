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
    internal class CTRLExpedientes
    {
        readonly CitasForm objCitasForm;
        readonly ControlPacientePlanillaUC objUC;
        public CTRLExpedientes(CitasForm Vista)
        {
            objCitasForm = Vista;

            objCitasForm.Load += new EventHandler(CargarExpedientes);
            objCitasForm.btnBuscar.Click += new EventHandler(BuscarExpedientes);
        }
        public CTRLExpedientes(ControlPacientePlanillaUC Vista)
        {
            objUC = Vista;

            objUC.btnDescargar.Click += new EventHandler(Cargar_info_Paciente);
        }
        public void CargarExpedientes(object sender, EventArgs e)
        {
            DAODiagnosticos objCitaUC = new DAODiagnosticos();
            DataTable dt = objCitaUC.Cargar();

            foreach (DataRow dr in dt.Rows)
            {
                //objCitaUC.CitaId = (int)dr[0];
                objCitaUC.DocumentoPaciente = (string)dr[0];
                objCitaUC.Nombre = (string)dr[1];
                objCitaUC.N_expediente = (int)dr[2];

                ControlPacientePlanillaUC PanelPaciente = new ControlPacientePlanillaUC(objCitaUC);
                objCitasForm.flpCitas.Controls.Add(PanelPaciente);
            }
        }
        public void BuscarExpedientes(object sender, EventArgs e)
        {
            DAODiagnosticos objCitas = new DAODiagnosticos();
            DataSet ds = objCitas.BuscarCita(objCitasForm.txtBuscarCita.Text.Trim());

            objCitasForm.flpCitas.Controls.Clear();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //objCitas.CitaId = (int)dr[0];
                objCitas.DocumentoPaciente = (string)dr[0];
                objCitas.Nombre = (string)dr[1];
                objCitas.N_expediente = (int)dr[2];

                ControlPacientePlanillaUC PanelPaciente = new ControlPacientePlanillaUC(objCitas);
                objCitasForm.flpCitas.Controls.Add(PanelPaciente);
            }
        }
        public void Cargar_info_Paciente(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = DateTime.Now.ToString("ddMMyyyy");
                guardar.FileName += ".pdf";
                guardar.Filter = "PDF file (*.pdf)|*.pdf";

                DAODiagnosticos objCitasDAO = new DAODiagnosticos();
                objCitasDAO.DocumentoPaciente = objUC.lblDUI.Text;
                objCitasDAO.CitaId = int.Parse(objUC.lblCitaId.Text);
                objCitasDAO.N_expediente = int.Parse(objUC.lblExpedienteId.Text);

                if (objCitasDAO.Obtener_expediente_Informacion() == true)
                {
                    string pag = Properties.Resources.Expediente__Psicosocial.ToString();

                    #region Variables remplazadas para la impresión del reporte
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
                    if (objCitasDAO.ObtenerDatosSistema() == true)
                    {
                        //Información del Sistema
                        pag = pag.Replace("@NOMBREEMPRESA", objCitasDAO.NombreEmpresa);
                        pag = pag.Replace("@TELEFONOEMPRESA", objCitasDAO.NumeroTelefono + objCitasDAO.NumeroPBX);
                        pag = pag.Replace("@UBICACION", objCitasDAO.DireccionEmpresa);
                        pag = pag.Replace("@CORREOEMPRESA", objCitasDAO.CorreoElectronicoE);

                        if (guardar.ShowDialog() == DialogResult.OK)
                        {
                            using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Phrase(""));

                                byte[] imagenEmpresa = objCitasDAO.FotoEmpresa;  
                                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagenEmpresa);
                                img.ScaleToFit(120, 100);
                                img.Alignment = iTextSharp.text.Image.UNDERLYING;
                                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 100);
                                pdfDoc.Add(img);

                                using (StringReader sr = new StringReader(pag))
                                {
                                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                                }

                                pdfDoc.Close();
                                stream.Close();
                            }
                        }
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