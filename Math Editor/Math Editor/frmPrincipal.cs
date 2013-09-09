using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MathEditor
{
    public partial class frmPrincipal : Form
    {
        FrmTools Elementos = new FrmTools();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string sourceName = "Default.html";
            string destName = "Current.html";
            string sourceFile = System.IO.Path.Combine(Application.StartupPath, sourceName);
            string destFile = System.IO.Path.Combine(Application.StartupPath, destName);
            System.IO.File.Copy(sourceFile, destFile, true);
            webBrowser1.Navigate(destFile);
            Elementos.Show();
        }

        private void mnuFullscreen_Click(object sender, EventArgs e)
        {
            if (TopMost == true)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                mnuFullscreen.Checked = false;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
                mnuFullscreen.Checked = true;
            }
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                mnuFullscreen.Checked = false;
            }
            else if (e.KeyCode == Keys.F11)
            {
                if (TopMost == true)
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    TopMost = false;
                    mnuFullscreen.Checked = false;
                }
                else
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    TopMost = true;
                    mnuFullscreen.Checked = true;
                }
            }
        }

        private string actualiza(string[] p)
        {
            string elm1 = "";
            string elm2 = "";
            string opr1 = "";
            string resp = "";
            int i = 0;
            string aux = "";
            if (i < p.Length)
            {
                aux = p[i];
                if (aux.Equals("("))
                {
                    int j = 1;
                    i++;
                    aux = "";
                    while ((j > 0) && (i < p.Length))
                    {
                        if (p[i].Equals(")"))
                        {
                            j--;
                            if (j > 0)
                            {
                                aux = aux + " " + p[i];
                            }
                        }
                        else if (p[i].Equals("("))
                        {
                            j++;
                            aux = aux + " " + p[i];
                        }
                        else
                        {
                            aux = aux + " " + p[i];
                        }
                        i++;
                    }
                    if (j != 0)
                    {
                        elm1 = "Error!";
                    }
                    else
                    {
                        elm1 = aux;
                    }
                }
                else if (aux != "")
                {
                    elm1 = aux;
                    i++;
                }
            }

            if (i < p.Length)
            {
                aux = p[i];
                if (aux.Equals("("))
                {
                    int j = 1;
                    i++;
                    aux = "";
                    while ((j > 0) && (i < p.Length))
                    {
                        if (p[i].Equals(")"))
                        {
                            j--;
                            if (j > 0)
                            {
                                aux = aux + " " + p[i];
                            }
                        }
                        else if (p[i].Equals("("))
                        {
                            j++;
                            aux = aux + " " + p[i];
                        }
                        else
                        {
                            aux = aux + " " + p[i];
                        }
                        i++;
                    }
                    if (j != 0)
                    {
                        opr1 = "Error!";
                    }
                    else
                    {
                        opr1 = aux;
                    }
                }
                else if (aux != "")
                {
                    opr1 = aux;
                    i++;
                }
            }

            if (i < p.Length)
            {
                aux = p[i];
                if (aux.Equals("("))
                {
                    int j = 1;
                    i++;
                    aux = "";
                    while ((j > 0) && (i < p.Length))
                    {
                        if (p[i].Equals(")"))
                        {
                            j--;
                            if (j > 0)
                            {
                                aux = aux + " " + p[i];
                            }
                        }
                        else if (p[i].Equals("("))
                        {
                            j++;
                            aux = aux + " " + p[i];
                        }
                        else
                        {
                            aux = aux + " " + p[i];
                        }
                        i++;
                    }
                    if (j != 0)
                    {
                        elm2 = "Error!";
                    }
                    else
                    {
                        elm2 = aux;
                    }
                }
                else if (aux != "")
                {
                    elm2 = aux;
                    i++;
                }
            }

            if (elm1 != "")
            {
                string[] partes = elm1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (partes.Length > 1)
                {
                    elm1 = "(" + actualiza(partes) + ")";
                }
                else if (elm1 == "<?>")
                {
                    elm1 = "□";
                }
                else if (elm1 == "emptyset")
                {
                    elm1 = "∅";
                }
            }

            if (opr1 != "")
            {
                string[] partes = opr1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (partes.Length > 1)
                {
                    opr1 = "(" + actualiza(partes) + ")";
                }
                else if (opr1 == "<?>")
                {
                    opr1 = "□";
                }
                else if (opr1 == "emptyset")
                {
                    opr1 = "∅";
                }
            }

            if (elm2 != "")
            {
                string[] partes = elm2.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (partes.Length > 1)
                {
                    elm2 = "(" + actualiza(partes) + ")";
                }
                else if (elm2 == "<?>")
                {
                    elm2 = "□";
                }
                else if (elm2 == "emptyset")
                {
                    elm2 = "∅";
                }
            }

            if (opr1 == "^")
            {
                resp = elm1 + "<SUP>" + elm2 + "</SUP>";
            }
            else if (opr1 == "_")
            {
                resp = elm1 + "<SUB>" + elm2 + "</SUB>";
            }
            else if (opr1 == "+-")
            {
                resp = elm1 + "±" + elm2;
            }
            else if (opr1 == "neg")
            {
                resp = elm1 + "¬" + elm2;
            }
            else if (opr1 == "cdot")
            {
                resp = elm1 + "·" + elm2;
            }
            else if (opr1 == "times")
            {
                resp = elm1 + "×" + elm2;
            }
            else if (opr1 == "and")
            {
                resp = elm1 + "∧" + elm2;
            }
            else if (opr1 == "or")
            {
                resp = elm1 + "∨" + elm2;
            }
            else if (opr1 == "div")
            {
                resp = elm1 + "÷" + elm2;
            }
            else if (opr1 == "over")
            {
                resp = "<SUP>" + elm1 + "</SUP>&frasl;<SUB>" + elm2 + "</SUB>";
            }
            else if (opr1 == "<>")
            {
                resp = elm1 + "≠" + elm2;
            }
            else if (opr1 == "approx")
            {
                resp = elm1 + "≈" + elm2;
            }
            else if (opr1 == "simeq")
            {
                resp = elm1 + "≃" + elm2;
            }
            else if ((opr1 == "leslant") || (opr1 == "<="))
            {
                resp = elm1 + "≤" + elm2;
            }
            else if ((opr1 == "geslant") || (opr1 == ">="))
            {
                resp = elm1 + "≥" + elm2;
            }
            else if (opr1 == "sim")
            {
                resp = elm1 + "∼" + elm2;
            }
            else if (opr1 == "equiv")
            {
                resp = elm1 + "≡" + elm2;
            }
            else if (opr1 == "toward")
            {
                resp = elm1 + "→" + elm2;
            }
            else
            {
                resp = elm1 + opr1 + elm2;
            }

            return resp;
        }

        private void cargaWeb()
        {
            string texto = txtFormula.Text;
            string[] partes = texto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string resultado = actualiza(partes);

            string tempName = "Temp.html";
            string tempFile = System.IO.Path.Combine(Application.StartupPath, tempName);
            if (System.IO.File.Exists(tempFile))
            {
                System.IO.File.Delete(tempFile);
            }
            System.IO.FileStream fs = System.IO.File.Create(tempFile);
            fs.Close();

            string sourceName = "Default.html";
            string sourceFile = System.IO.Path.Combine(Application.StartupPath, sourceName);
            string[] lineas = System.IO.File.ReadAllLines(sourceFile);
            lineas[28] = "<CENTER><DIV id=\"centeredcontent\">" + resultado + "</DIV></CENTER>";

            System.IO.File.WriteAllLines(tempFile, lineas);

            string destName = "Current.html";
            string destFile = System.IO.Path.Combine(Application.StartupPath, destName);
            System.IO.File.Copy(tempFile, destFile, true);

            webBrowser1.Navigate(destFile); 
        }

        private void txtFormula_TextChanged(object sender, EventArgs e)
        {
            toolModif.Text = "true";
            if (mnuAutom.Checked == true)
            {
                cargaWeb();
            }
        }

        private void mnuActualizar_Click(object sender, EventArgs e)
        {
            cargaWeb();
        }

        private void mnuAbrir_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "math formula files (*.fml)|*.fml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        toolPath.Text = openFileDialog1.FileName;
                        string[] partes = toolPath.Text.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                        toolFile.Text = partes[partes.Length - 1];
                        this.Text = toolFile.Text + " - Math Editor";
                        string[] lineas = System.IO.File.ReadAllLines(toolPath.Text);
                        txtFormula.Text = lineas[0];
                        toolModif.Text = "false";
                        cargaWeb();
                        myStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void mnuGuardarComo_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "math formula files (*.fml)|*.fml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close(); 
                    toolPath.Text = saveFileDialog1.FileName;
                    string[] partes = toolPath.Text.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                    toolFile.Text = partes[partes.Length - 1];
                    this.Text = toolFile.Text + " - Math Editor";
                    string[] lineas = new string[1];
                    lineas[0] = txtFormula.Text;
                    System.IO.File.WriteAllLines(toolPath.Text, lineas);
                }
            }

            toolModif.Text = "false";
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 Acerd = new AboutBox1();
            Acerd.Show();
        }

        private void estándarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (estándarToolStripMenuItem.Checked == false)
            {
                toolStrip1.Visible = false;
            }
            else
            {
                toolStrip1.Visible = true;
            }
        }

        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (barraDeEstadoToolStripMenuItem.Checked == false)
            {
                statusStrip1.Visible = false;
            }
            else
            {
                statusStrip1.Visible = true;
            }
        }

        private void mnuGuardar_Click(object sender, EventArgs e)
        {
            if (toolPath.Text != "")
            {
                string[] lineas = new string[1];
                lineas[0] = txtFormula.Text;
                System.IO.File.WriteAllLines(toolPath.Text, lineas);
            }
            else
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "math formula files (*.fml)|*.fml";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        myStream.Close();
                        toolPath.Text = saveFileDialog1.FileName;
                        string[] partes = toolPath.Text.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                        toolFile.Text = partes[partes.Length - 1];
                        this.Text = toolFile.Text + " - Math Editor";
                        string[] lineas = new string[1];
                        lineas[0] = txtFormula.Text;
                        System.IO.File.WriteAllLines(toolPath.Text, lineas);
                    }
                }
            }

            toolModif.Text = "false";
        }

        private void exportarComoHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Hyper Terminal Markup Language file (*.html)|*.html";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    string destino = saveFileDialog1.FileName;
                    string sourceName = "Current.html";
                    string sourceFile = System.IO.Path.Combine(Application.StartupPath, sourceName);
                    System.IO.File.Copy(sourceFile, destino, true);
                }
            }
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            if (toolModif.Text.Equals("true"))
            {
                if (toolFile.Text != "")
                {
                    DialogResult dialog = MessageBox.Show("¿Desea guardar los cambios en \"" + toolFile + "\"?", "Guardar Documento", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string[] lineas = new string[1];
                        lineas[0] = txtFormula.Text;
                        System.IO.File.WriteAllLines(toolPath.Text, lineas);
                        Application.Exit();
                    }
                    else if (dialog == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("¿Desea guardar los cambios en \"Sin Título\"?", "Guardar Documento", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "math formula files (*.fml)|*.fml";
                        saveFileDialog1.FilterIndex = 1;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {
                                myStream.Close();
                                toolPath.Text = saveFileDialog1.FileName;
                                string[] partes = toolPath.Text.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                                toolFile.Text = partes[partes.Length - 1];
                                this.Text = toolFile.Text + " - Math Editor";
                                string[] lineas = new string[1];
                                lineas[0] = txtFormula.Text;
                                System.IO.File.WriteAllLines(toolPath.Text, lineas);
                            }
                        }
                        Application.Exit();
                    }
                    else if (dialog == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
            Close();
        }

        private void mnuNuevo_Click(object sender, EventArgs e)
        {
            if (toolModif.Text.Equals("true"))
            {
                if (toolFile.Text != "")
                {
                    DialogResult dialog = MessageBox.Show("¿Desea guardar los cambios en \"" + toolFile + "\"?", "Guardar Documento", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string[] lineas = new string[1];
                        lineas[0] = txtFormula.Text;
                        System.IO.File.WriteAllLines(toolPath.Text, lineas);
                        toolPath.Text = "";
                        toolFile.Text = "";
                        toolModif.Text = "false";
                        txtFormula.Text = "";
                        this.Text = "Sin Título - Math Editor";
                    }
                    else if (dialog == DialogResult.No)
                    {
                        toolPath.Text = "";
                        toolFile.Text = "";
                        toolModif.Text = "false";
                        txtFormula.Text = "";
                        this.Text = "Sin Título - Math Editor";
                    }
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("¿Desea guardar los cambios en \"Sin Título\"?", "Guardar Documento", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        Stream myStream;
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "math formula files (*.fml)|*.fml";
                        saveFileDialog1.FilterIndex = 1;
                        saveFileDialog1.RestoreDirectory = true;

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if ((myStream = saveFileDialog1.OpenFile()) != null)
                            {
                                myStream.Close();
                                toolPath.Text = saveFileDialog1.FileName;
                                string[] partes = toolPath.Text.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                                toolFile.Text = partes[partes.Length - 1];
                                this.Text = toolFile.Text + " - Math Editor";
                                string[] lineas = new string[1];
                                lineas[0] = txtFormula.Text;
                                System.IO.File.WriteAllLines(toolPath.Text, lineas);
                            }
                        }
                        toolPath.Text = "";
                        toolFile.Text = "";
                        toolModif.Text = "false";
                        txtFormula.Text = "";
                        this.Text = "Sin Título - Math Editor";
                    }
                    else if (dialog == DialogResult.No)
                    {
                        toolPath.Text = "";
                        toolFile.Text = "";
                        toolModif.Text = "false";
                        txtFormula.Text = "";
                        this.Text = "Sin Título - Math Editor";
                    }
                }
            }
        }

        private void elementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (elementosToolStripMenuItem.Checked == false)
            {
                Elementos.Hide();
            }
            else
            {
                Elementos.Show();
            }
        }

        private void Elementos_FormClosing(object sender, FormClosingEventArgs e)
        {
            elementosToolStripMenuItem.Checked = false;
        }
    }
}
