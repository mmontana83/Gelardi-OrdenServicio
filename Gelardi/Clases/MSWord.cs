using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Gelardi.Clases
{
    class MSWord
    {
        // objetos para usar Word
        private _Application aplicWord;
        private _Document docWord;

        object path;
        object soloLectura;

        public void imprimirOrdenServicio(string denominacion, string documento, string telefono, string domicilio,
            string localidad, string email, string patente, string modelo, string color, string nroMotor, string nroChasis,
            string nroUnidad, string fechaRecepcion, string fechaPrometida, string fechaEntrega, string KM, string garantia,
            string tipoServicio, string totalPrecio, string[] observaciones, string[,] trabajos, int cantTrabajos)
        {
            int i;

            path = System.Windows.Forms.Application.StartupPath + @"\\orderServicio_Plantilla.doc";
            soloLectura = true;

            // Objetos de intercambio con Interop Word
            Object oMissing = System.Reflection.Missing.Value;
            Object oFalse = false;

            // inicializar aplicacion
            aplicWord = new Microsoft.Office.Interop.Word.Application();

            // Agregar un documento nuevo.
            docWord = aplicWord.Documents.Open(ref path, ref oMissing,
                ref soloLectura, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            docWord.Tables[1].Cell(1, 1).Range.InsertAfter(denominacion);
            docWord.Tables[1].Cell(1, 2).Range.InsertAfter(patente);
            docWord.Tables[1].Cell(1, 3).Range.InsertAfter(fechaRecepcion);
            docWord.Tables[1].Cell(1, 4).Range.InsertAfter(KM);

            docWord.Tables[1].Cell(2, 1).Range.InsertAfter(documento);
            docWord.Tables[1].Cell(2, 2).Range.InsertAfter(telefono);
            docWord.Tables[1].Cell(2, 3).Range.InsertAfter(modelo);
            docWord.Tables[1].Cell(2, 4).Range.InsertAfter(color);

            docWord.Tables[1].Cell(4, 1).Range.InsertAfter(domicilio);
            docWord.Tables[1].Cell(4, 3).Range.InsertAfter(nroMotor);
            docWord.Tables[1].Cell(3, 5).Range.InsertAfter(fechaPrometida);

            docWord.Tables[1].Cell(5, 1).Range.InsertAfter(localidad);
            docWord.Tables[1].Cell(5, 3).Range.InsertAfter(nroChasis);

            docWord.Tables[1].Cell(6, 4).Range.InsertAfter(fechaEntrega);
            docWord.Tables[1].Cell(6, 5).Range.InsertAfter(garantia);

            docWord.Tables[1].Cell(7, 1).Range.InsertAfter(email);
            docWord.Tables[1].Cell(7, 2).Range.InsertAfter(nroUnidad);

            docWord.Tables[1].Cell(26, 2).Range.InsertAfter(observaciones[0]);
            docWord.Tables[1].Cell(27, 1).Range.InsertAfter(observaciones[1]);
            docWord.Tables[1].Cell(28, 1).Range.InsertAfter(observaciones[2]);
            docWord.Tables[1].Cell(29, 1).Range.InsertAfter(observaciones[3]);
            docWord.Tables[1].Cell(30, 1).Range.InsertAfter(observaciones[4]);
            string precio = "";

            if (cantTrabajos >= 16)
            {
                docWord.Tables[1].Select();
                aplicWord.Selection.Copy();
                object pgBreak = (int)WdBreakType.wdPageBreak;
                aplicWord.Selection.InsertBreak(ref pgBreak);
                object unit;
                unit = WdUnits.wdStory;
                aplicWord.Selection.HomeKey(ref unit, ref oMissing);
                aplicWord.Selection.Paste();

                i = 0;
                int countTrabajos = 0;
                int filas = 0;
                for (int j = 1; j <= docWord.Tables.Count; j++)
                {
                    while (i < cantTrabajos)
                    {
                        if (trabajos[2, countTrabajos] != "$0,00")
                            precio = trabajos[2, countTrabajos];
                        else
                            precio = "";
                        docWord.Tables[j].Cell(filas + 10, 1).Range.InsertAfter(trabajos[0, countTrabajos]);
                        docWord.Tables[j].Cell(filas + 10, 2).Range.InsertAfter(trabajos[1, countTrabajos]);
                        if (trabajos[1, countTrabajos].Contains("MANO DE OBRA") && trabajos[4, countTrabajos].ToUpper() == "SELECCIONADO")
                            docWord.Tables[j].Cell(filas + 10, 3).Range.InsertAfter(trabajos[3, countTrabajos]); 
                        docWord.Tables[j].Cell(filas + 10, 4).Range.InsertAfter(precio);
                        filas += 1;
                        countTrabajos += 1;
                        i += 1;
                        if (i == 16)
                        {
                            break;
                        }
                    }
                    filas = 0;
                }

                if ((tipoServicio != "PDI") && (tipoServicio != "1000") && (!tipoServicio.Contains("Garantía")))
                {
                    docWord.Tables[1].Cell(25, 2).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    docWord.Tables[2].Cell(25, 2).Range.InsertAfter(String.Format("TOTAL SERVICIO {0} KM", tipoServicio));
                    docWord.Tables[2].Cell(25, 2).Range.Bold = 1;

                    if (totalPrecio != "$0,00")
                        docWord.Tables[2].Cell(25, 4).Range.InsertAfter(totalPrecio);
                    else
                        docWord.Tables[2].Cell(25, 4).Range.InsertAfter("-");
                }

            }
            else
            {
                for (i = 0; i < cantTrabajos; i++)
                {
                    if (trabajos[2, i] != "$0,00")
                        precio = trabajos[2, i];
                    else precio = "";
                    docWord.Tables[1].Cell(i + 10, 1).Range.InsertAfter(trabajos[0, i]);
                    docWord.Tables[1].Cell(i + 10, 2).Range.InsertAfter(trabajos[1, i]);
                    if (trabajos[1, i].Contains("MANO DE OBRA") && trabajos[4, i].ToUpper() == "SELECCIONADO")
                        docWord.Tables[1].Cell(i + 10, 3).Range.InsertAfter(trabajos[3, i]); 
                    docWord.Tables[1].Cell(i + 10, 4).Range.InsertAfter(precio);
                }

                if ((tipoServicio != "PDI") && (tipoServicio != "1000") && (!tipoServicio.Contains("Garantía")))
                {
                    docWord.Tables[1].Cell(25, 2).Range.InsertAfter(String.Format("TOTAL SERVICIO {0} KM", tipoServicio));
                    docWord.Tables[1].Cell(25, 2).Range.Bold = 1;

                    if (totalPrecio != "$0,00")
                        docWord.Tables[1].Cell(25, 4).Range.InsertAfter(totalPrecio);
                    else
                        docWord.Tables[1].Cell(25, 4).Range.InsertAfter("-");
                }
            }

            //Muestro la aplicación
            aplicWord.Visible = true;
        }
    }    
}
