using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperCRUDWinFormsMVP.Views
{
    public partial class PetView : Form, IPetView
    {
        private string menssagem;
        private bool bemSucedido;
        //construtor
        public PetView()
        {
            InitializeComponent();
            AssociarEMostrarEventosView();
            tabControl1.TabPages.Remove(tpDetalhes);
        }

        private void AssociarEMostrarEventosView()
        {
            btnProcurar.Click += delegate { ProcurarEvent?.Invoke(this, EventArgs.Empty); };
            tbProcurar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ProcurarEvent?.Invoke(this, EventArgs.Empty);
                };
            };
        }

        //propriedades
        public string PetId { get => tbID.Text; set => tbID.Text=value; }
        public string PetNome { get => tbNome.Text; set => tbNome.Text = value; }
        public string PetTipo { get => tbTipo.Text; set => tbTipo.Text = value; }
        public string PetCor { get => tbCor.Text; set => tbCor.Text = value; }
        public string ProcurarValor { get => tbProcurar.Text; set => tbProcurar.Text = value; }
        public bool Editar { get => Editar; set => Editar = value; }
        public bool BemSucedido { get => BemSucedido; set => BemSucedido = value; }
        public string Menssagem { get => menssagem; set => menssagem = value; }
       

        //eventos
        public event EventHandler ProcurarEvent;
        public event EventHandler NovoEvent;
        public event EventHandler EditarEvent;
        public event EventHandler DeletarEvent;
        public event EventHandler SalvarEvent;
        public event EventHandler CancelarEvent;


        public void SetListaPetBindingSource(BindingSource listaPet)
        {
            dataGridView.DataSource = listaPet;
        }



        

       
    }
}
