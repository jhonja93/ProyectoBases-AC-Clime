using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Busqueda_vehiculo : Form
    {
        public Busqueda_vehiculo()
        {
            InitializeComponent();
        }

        private void Buscar_Vehiculo_cedula(){


            
            this.list_v_cliente.View = View.Details;
            for (int i = 0; i < NVehiculo.BuscarCedula(this.bscr_v_box.Text).Rows.Count; i++)
            {

                DataRow drow = NVehiculo.BuscarCedula(this.bscr_v_box.Text).Rows[i];

                if(drow.RowState != DataRowState.Deleted){

                    ListViewItem vh_clie = new ListViewItem(drow["_IdCliente"].ToString());
                    vh_clie.SubItems.Add(drow["_PlacaVeh"].ToString());
                    vh_clie.SubItems.Add(drow["_Marca"].ToString());
                    vh_clie.SubItems.Add(drow["_Modelo"].ToString());


                    list_v_cliente.Items.Add(vh_clie);

                    
                }
            }

           //vh_clie.SubItems.Add(NVehiculo.BuscarCedula(this.bscr_v_box.Text));


            
        }
        private void Buscar_Vehiculo_placa()
        {
            this.list_v_mant.View = View.Details;
            for (int i = 0; i < NVehiculo.BuscarPlaca(this.bscr_v_box.Text).Rows.Count; i++)
            {

                DataRow drow = NVehiculo.BuscarPlaca(this.bscr_v_box.Text).Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {

                    ListViewItem vh_mant = new ListViewItem(drow["_IdCliente"].ToString());
                    vh_mant.SubItems.Add(drow["_PlacaVeh"].ToString());
                    vh_mant.SubItems.Add(drow["_Marca"].ToString());
                    vh_mant.SubItems.Add(drow["_Modelo"].ToString());


                    list_v_mant.Items.Add(vh_mant);


                }
            }
        }

        private void bscr_v_box_TextChanged(object sender, EventArgs e)
        {
            bscr_v_btn_Click(sender,e);
        }

        private void bscr_v_btn_Click(object sender, EventArgs e)
        {
            if (rad_ced.Checked && rad_plk.Checked == false) this.Buscar_Vehiculo_cedula();
            if (rad_plk.Checked && rad_ced.Checked == false) this.Buscar_Vehiculo_placa();

        }

        private void list_v_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        

       


       



       
    }
}
