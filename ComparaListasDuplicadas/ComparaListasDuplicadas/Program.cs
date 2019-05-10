﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparaListasDuplicadas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            try
            {
                var lista1 = new List<string>();
                var lista2 = new List<string>();
                string selectedFolder = null;

                OpenFileDialog openFile = new OpenFileDialog();
                openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer).ToString();
                openFile.Title = "Escolha o Arquivo";
                openFile.Filter = "Arquivos de Texto (*.txt) | *.txt";

                if (openFile.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                selectedFolder = openFile.FileName;
                var selectedFolderPath = openFile.FileName.Replace(openFile.SafeFileName, "");

                var sr = new StreamReader(selectedFolder, Encoding.Default);

                while (!sr.EndOfStream)
                {
                    var item = sr.ReadLine().Split('\t');
                    lista1.Add(item[0]);
                    lista2.Add(item[1]);
                }
                sr.Dispose();

                #region MétodoFeitoNaUnha
                //foreach (var item1 in lista1)
                //{
                //    bool encontrou = false;

                //    foreach (var item2 in lista2)
                //    {
                //        if (item1 == item2)
                //        {
                //            ItemsDuplicados.Add(item1);
                //            encontrou = true;
                //            break;
                //        }
                //        else
                //        {
                //            encontrou = false;
                //        }
                //    }

                //    if (encontrou == false)
                //    {
                //        itemsExclusivosLista1.Add(item1);
                //    }

                //}

                //foreach (var item2 in lista2)
                //{
                //    bool encontrou = false;

                //    foreach (var item1 in lista1)
                //    {
                //        if (item1 == item2)
                //        {
                //            encontrou = true;
                //            break;
                //        }
                //        else
                //        {
                //            encontrou = false;
                //        }
                //    }

                //    if (encontrou == false)
                //    {
                //        itemsExclusivosLista2.Add(item2);
                //    }
                //} 
                #endregion

                var ItemsDuplicados = lista1.Intersect(lista2).ToList();
                var itemsExclusivosLista1 = lista1.Except(lista2).ToList();
                var itemsExclusivosLista2 = lista2.Except(lista1).ToList();

                string caminhoListaRegistrosDuplicados = (selectedFolderPath + $@"\Exported_at_{DateTime.Now.ToString("dd-MM-yyyy")}_as_{DateTime.Now.ToString("H'h'mm")}_ListaRegistrosDuplicados - Qtd {ItemsDuplicados.Count}.txt");
                string caminhoListaExclusivos1 = (selectedFolderPath + $@"\Exported_at_{DateTime.Now.ToString("dd-MM-yyyy")}_as_{DateTime.Now.ToString("H'h'mm")}_ItemsExclusivosLista1 - Qtd {itemsExclusivosLista1.Count}.txt");
                string caminhoListaExclusivos2 = (selectedFolderPath + $@"\Exported_at_{DateTime.Now.ToString("dd-MM-yyyy")}_as_{DateTime.Now.ToString("H'h'mm")}_ItemsExclusivosLista2 - Qtd {itemsExclusivosLista2.Count}.txt");

                Write(itemsExclusivosLista1, caminhoListaExclusivos1);
                Write(itemsExclusivosLista2, caminhoListaExclusivos2);
                Write(ItemsDuplicados, caminhoListaRegistrosDuplicados);

                void Write(List<string> lista, string outputFilePath)
                {
                    using (StreamWriter sw = new StreamWriter(outputFilePath, false))
                    {
                        foreach (var item in lista)
                        {
                            sw.WriteLine($"{item}");
                        }
                        sw.Close();
                    }
                }

                MessageBox.Show("Informações exportadas para " + selectedFolderPath.ToString(),
                "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
