using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAQUINATURING
{
    public partial class Form1 : Form
    {
        private string elAlfabeto = "";
        private const char EspacioBlanco = 'Δ';
        private ListViewItem cabezalQueMueveLaMaquina = null;
        private char[] cadenaEntrada;
        private List<Operacion> operacionesDelAmaquinba = new List<Operacion>();
        private int delay = 100;

        public Form1()
        {
            InitializeComponent();
        }
        private void eventoAgregarAlfabeto()
        {
            string caracterIngresado = txtCaracterAlfabeto.Text;
            if (string.IsNullOrWhiteSpace(caracterIngresado))
            {
                MessageBox.Show("Ingrese un caracter");
                return;
            }

            if (elAlfabeto.Contains(caracterIngresado))
            {
                return;
            }

            agregarCaracterAlfabeto(caracterIngresado);
        }

        private void agregarCaracterAlfabeto(string caracterIngresado)
        {
            elAlfabeto += caracterIngresado;
            lblAlfabeto.Text = "Alfabeto = {" + elAlfabeto + "Δ}";
            txtCaracterAlfabeto.Clear();
            txtCaracterAlfabeto.Focus();
        }

        private void btnAgregarCaracterAlfabeto_Click(object sender, EventArgs e)
        {
            eventoAgregarAlfabeto();
        }

        private void guardarCadenaEntradaEnCeldas()
        {
            foreach (char caracter in cadenaEntrada)
            {
                alfabetoEnCeldas.Items.Add(caracter.ToString());
            }
        }



        

        private void btnGuardarCadenaEntrada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(elAlfabeto))
            {
                MessageBox.Show("Ingrese un elemento al alfabeto.");
                return;
            }

            cadenaEntrada = txtCadenaEntrada.Text.ToCharArray();
            guardarCadenaEntradaEnCeldas();
        }

        private void btnAgregarAccion_Click(object sender, EventArgs e)
        {


            //Array de enumerbles
            var v = Enum.GetValues(typeof(Movimientos));
            var b = Enum.GetValues(typeof(Acciones));
            int contM = 0;
            int contA = 0;
            //reemplazalo
            //puroradioobutton
            // Moverse hacia la derecha...... . .. . . 
            foreach(var i in grpMovimientos.Controls)
            {
                contM++;
                if(i is RadioButton && (i as RadioButton).Checked)
                {
                    break;
                }
            }


            //obtener mov.
            var x = v.GetValue(contM-1);
            

            foreach (var j in grpAcciones.Controls)
            {
                contA++;
                if (j is RadioButton && (j as RadioButton).Checked)
                {
                    break;
                }
            }

            var y = b.GetValue(contA-1);

            Operacion nuevaOperacion = new Operacion((Movimientos) x, (Acciones)y);
            Movimientos movimientoSeleccionado = (Movimientos)x;

            if (movimientoSeleccionado == Movimientos.MoverDerecha || movimientoSeleccionado == Movimientos.MoverIzquierda)
            {
                if (string.IsNullOrWhiteSpace(txtCaracterAuxiliar.Text))
                {
                    MessageBox.Show("Ingrese un caracter.");
                    txtCaracterAuxiliar.Focus();
                    return;
                }
                if (!elAlfabeto.Contains(txtCaracterAuxiliar.Text) && !txtCaracterAuxiliar.Text.Equals(EspacioBlanco.ToString()))
                {
                    txtCaracterAuxiliar.Focus();
                    return;
                }

                nuevaOperacion.CaracterPerteneceAMov = txtCaracterAuxiliar.Text.ElementAt(0);

                //btnResetearMovimientos.Enabled = true;
            }

            if (nuevaOperacion.Accion == Acciones.ReemplazarPorUnCaracter)
            {
                if (string.IsNullOrWhiteSpace(txtCaracterReemplazar.Text))
                {
                    MessageBox.Show("Ingrese el caracter a reemplazar");
                    txtCaracterReemplazar.Focus();
                    return;
                }
                if (!elAlfabeto.Contains(txtCaracterReemplazar.Text))
                {
                    txtCaracterReemplazar.Focus();
                    return;
                }

                nuevaOperacion.AccionCaracter = txtCaracterReemplazar.Text.ElementAt(0);
            }

            operacionesDelAmaquinba.Add(nuevaOperacion);

            clearMovs();
        }

        private async void btnEncenderMaquina_Click(object sender, EventArgs e)
        {
            if (operacionesDelAmaquinba.Count == 0)
            {
                MessageBox.Show("No hay operaciones");
                return;
            }
            delay = 1000;
            bool seAceptaCadena = await procesoMaestro();
            if (seAceptaCadena)
            {
                MessageBox.Show("La cadena ha sido aceptada.");

            }
        }

        private async Task<bool> procesoMaestro()
        {
            ListViewItem cabezal;
            try
            {
                cabezal = cabezalQueMueveLaMaquina;
            }
            catch
            {
                MessageBox.Show("Cadena no encontrada.");
                return await Task.FromResult(false);
            }

            int iterador = cabezal.Index;
            ListViewItem item = null;
            foreach (Operacion operacion in operacionesDelAmaquinba)
            {
                //dgvAcciones.Rows[numOperacion++].Selected = true;
                switch (operacion.Movimiento)
                {
                    case Movimientos.MoverDerecha:
                        iterador++;
                        while (true)
                        {
                            if (iterador == cadenaEntrada.Length)
                            {
                                MessageBox.Show("Problema en la parada. La cadena no fue aceptada...");
                                return await Task.FromResult(false);
                            }

                            if (false ? cadenaEntrada[iterador] != operacion.CaracterPerteneceAMov : cadenaEntrada[iterador] == operacion.CaracterPerteneceAMov)
                            {
                                try
                                {
                                    alfabetoEnCeldas.Items[iterador].Selected = true;
                                }
                                catch { }
                                break;
                            }

                            item = alfabetoEnCeldas.Items[iterador];
                            alfabetoEnCeldas.Items[iterador].Selected = true; //Cambio visual


                            switch (operacion.Accion)
                            {
                                case Acciones.ReemplazarPorBlanco:
                                    cadenaEntrada[iterador] = EspacioBlanco;
                                    item.Text = EspacioBlanco.ToString();
                                    break;
                                case Acciones.ReemplazarPorUnCaracter:
                                    cadenaEntrada[iterador] = operacion.AccionCaracter; //Cambia el valor en la cadena real
                                    item.Text = operacion.AccionCaracter.ToString(); //Cambia el valor visible en las celdas
                                    break;
                                case Acciones.Sobreescribir:
                                    break;
                            }

                            await Task.Delay(delay);
                            iterador++;
                        }
                        break;

                    case Movimientos.MoverIzquierda:
                        iterador--;
                        while (true)
                        {
                            if (iterador == -1)
                            {
                                MessageBox.Show("Terminacion anormal. La cadena no fue aceptada...");
                                return await Task.FromResult(false);
                            }
                            if (false ? cadenaEntrada[iterador] != operacion.CaracterPerteneceAMov : cadenaEntrada[iterador] == operacion.CaracterPerteneceAMov)
                            {
                                try
                                {
                                    alfabetoEnCeldas.Items[iterador].Selected = true;
                                }
                                catch { }
                                break;
                            }

                            item = alfabetoEnCeldas.Items[iterador];
                            alfabetoEnCeldas.Items[iterador].Selected = true;

                            switch (operacion.Accion)
                            {
                                case Acciones.ReemplazarPorBlanco:
                                    cadenaEntrada[iterador] = EspacioBlanco;
                                    item.Text = EspacioBlanco.ToString();
                                    break;
                                case Acciones.ReemplazarPorUnCaracter:
                                    cadenaEntrada[iterador] = operacion.AccionCaracter;
                                    item.Text = operacion.AccionCaracter.ToString();
                                    break;
                                case Acciones.Sobreescribir:
                                    break;
                            }

                            await Task.Delay(delay);
                            iterador--;
                        }
                        break;

                    case Movimientos.MoverUnoPorDerecha:
                        iterador++;
                        if (iterador == cadenaEntrada.Length)
                        {
                            MessageBox.Show("Problema en la parada.");
                            return await Task.FromResult(false);
                        }

                        item = alfabetoEnCeldas.Items[iterador];
                        switch (operacion.Accion)
                        {
                            case Acciones.ReemplazarPorBlanco:
                                cadenaEntrada[iterador] = EspacioBlanco;
                                item.Text = EspacioBlanco.ToString();
                                break;
                            case Acciones.ReemplazarPorUnCaracter:
                                cadenaEntrada[iterador] = operacion.AccionCaracter;
                                item.Text = operacion.AccionCaracter.ToString();
                                break;
                            case Acciones.Sobreescribir:
                                break;
                        }

                        alfabetoEnCeldas.Items[iterador].Selected = true;
                        await Task.Delay(delay);
                        break;

                    case Movimientos.MoverUnoPorIzquierda:
                        iterador--;
                        if (iterador == -1)
                        {
                            MessageBox.Show("Problema en la parada.");
                            return await Task.FromResult(false);
                        }

                        item = alfabetoEnCeldas.Items[iterador];
                        switch (operacion.Accion)
                        {
                            case Acciones.ReemplazarPorBlanco:
                                cadenaEntrada[iterador] = EspacioBlanco; //Cambia el valor en la cadena real
                                item.Text = EspacioBlanco.ToString(); //Cambia el valor visible en las celdas
                                break;
                            case Acciones.ReemplazarPorUnCaracter:
                                cadenaEntrada[iterador] = operacion.AccionCaracter; //Cambia el valor en la cadena real
                                item.Text = operacion.AccionCaracter.ToString(); //Cambia el valor visible en las celdas
                                break;
                            case Acciones.Sobreescribir:
                                break;
                        }

                        alfabetoEnCeldas.Items[iterador].Selected = true; //Cambio visual
                        await Task.Delay(delay);
                        break;

                    case Movimientos.Mantenerse:

                        item = alfabetoEnCeldas.Items[iterador];
                        switch (operacion.Accion)
                        {
                            case Acciones.ReemplazarPorBlanco:
                                cadenaEntrada[iterador] = EspacioBlanco;
                                item.Text = EspacioBlanco.ToString();
                                break;
                            case Acciones.ReemplazarPorUnCaracter:
                                cadenaEntrada[iterador] = operacion.AccionCaracter;
                                item.Text = operacion.AccionCaracter.ToString();
                                break;
                            case Acciones.Sobreescribir:
                                break;
                        }

                        alfabetoEnCeldas.Items[iterador].Selected = true;
                        await Task.Delay(delay);
                        break;
                }
            }

            return await Task.FromResult(true);
        }

        private void txtCadenaEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !elAlfabeto.Contains(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void alfabetoEnCeldas_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            SolidBrush normal = new SolidBrush(Color.White);
            SolidBrush cabezal = new SolidBrush(Color.LimeGreen);
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(cabezal, e.Bounds);
            }
            else e.Graphics.FillRectangle(normal, e.Bounds);
            e.Graphics.DrawRectangle(Pens.Black, e.Bounds);
            TextRenderer.DrawText(e.Graphics, e.Item.Index.ToString() + " - " + e.Item.Text, alfabetoEnCeldas.Font, e.Bounds,
                                   Color.Black, Color.Empty,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        private void clearMovs()
        {
            txtCaracterAuxiliar.Text = "";
            txtCaracterReemplazar.Text = "";
        }

        private void alfabetoEnCeldas_Click(object sender, EventArgs e)
        {
        }

        private void txtCaracterAuxiliar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
                e.KeyChar = EspacioBlanco;
            else if (e.KeyChar != '\b' && !elAlfabeto.Contains(e.KeyChar))
            {
                MessageBox.Show("Caracter no valido en el alfabeto");
            };
        }

        private void txtCaracterReemplazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = EspacioBlanco;
            else if (e.KeyChar != '\b' && !elAlfabeto.Contains(e.KeyChar))
            {
                MessageBox.Show("Caracter no valido en el alfabeto");
            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea reiniciar la maquina?.", "Reinicio", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                cadenaEntrada = null;
                alfabetoEnCeldas.Items.Clear();
                operacionesDelAmaquinba.Clear();
                //dgvAcciones.Rows.Clear();
                //lblSelectedItemList.Text = "Cabezal seleccionado:";
                elAlfabeto = "";
                lblAlfabeto.Text = "";
                //listBoxAlfabeto.Items.Clear();
                //groupBox2.Enabled = groupBox3.Enabled = true;
                txtCadenaEntrada.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCadenaEntrada.Text = txtCadenaEntrada.Text + EspacioBlanco.ToString();
        }

        private void txtCaracterAuxiliar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCaracterReemplazar_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtPosCabezal.Text);
            alfabetoEnCeldas.Items[pos].Selected = true;

            var cabezalSeleccionado = alfabetoEnCeldas.SelectedItems[0];
            cabezalQueMueveLaMaquina = cabezalSeleccionado;
        }

        private void alfabetoEnCeldas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //XD
        }

        private void txtPosCabezal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
