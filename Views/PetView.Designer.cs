namespace SuperCRUDWinFormsMVP.Views
{
    partial class PetView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.ListBox();
            this.btnExcluir = new DevComponents.DotNetBar.ButtonX();
            this.btnEditar = new DevComponents.DotNetBar.ButtonX();
            this.btnNovo = new DevComponents.DotNetBar.ButtonX();
            this.btnProcurar = new DevComponents.DotNetBar.ButtonX();
            this.tbProcurar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.tpDetalhes = new System.Windows.Forms.TabPage();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnSalvar = new DevComponents.DotNetBar.ButtonX();
            this.tbTipo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbCor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbNome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPet = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpLista.SuspendLayout();
            this.tpDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PETS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLista);
            this.tabControl1.Controls.Add(this.tpDetalhes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 407);
            this.tabControl1.TabIndex = 1;
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.dataGridView);
            this.tpLista.Controls.Add(this.btnExcluir);
            this.tpLista.Controls.Add(this.btnEditar);
            this.tpLista.Controls.Add(this.btnNovo);
            this.tpLista.Controls.Add(this.btnProcurar);
            this.tpLista.Controls.Add(this.tbProcurar);
            this.tpLista.Controls.Add(this.label2);
            this.tpLista.Location = new System.Drawing.Point(4, 25);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(792, 378);
            this.tpLista.TabIndex = 0;
            this.tpLista.Text = "Lista";
            this.tpLista.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.FormattingEnabled = true;
            this.dataGridView.ItemHeight = 16;
            this.dataGridView.Location = new System.Drawing.Point(21, 69);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(636, 260);
            this.dataGridView.TabIndex = 7;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExcluir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExcluir.Location = new System.Drawing.Point(677, 127);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditar.Location = new System.Drawing.Point(677, 98);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            // 
            // btnNovo
            // 
            this.btnNovo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNovo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNovo.Location = new System.Drawing.Point(677, 69);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            // 
            // btnProcurar
            // 
            this.btnProcurar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnProcurar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnProcurar.Location = new System.Drawing.Point(582, 34);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            // 
            // tbProcurar
            // 
            // 
            // 
            // 
            this.tbProcurar.Border.Class = "TextBoxBorder";
            this.tbProcurar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbProcurar.Location = new System.Drawing.Point(21, 34);
            this.tbProcurar.Name = "tbProcurar";
            this.tbProcurar.Size = new System.Drawing.Size(555, 22);
            this.tbProcurar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Procurar pet:";
            // 
            // tpDetalhes
            // 
            this.tpDetalhes.Controls.Add(this.btnCancelar);
            this.tpDetalhes.Controls.Add(this.btnSalvar);
            this.tpDetalhes.Controls.Add(this.tbTipo);
            this.tpDetalhes.Controls.Add(this.tbID);
            this.tpDetalhes.Controls.Add(this.tbCor);
            this.tpDetalhes.Controls.Add(this.tbNome);
            this.tpDetalhes.Controls.Add(this.label3);
            this.tpDetalhes.Controls.Add(this.label5);
            this.tpDetalhes.Controls.Add(this.label4);
            this.tpDetalhes.Controls.Add(this.txtIdPet);
            this.tpDetalhes.Location = new System.Drawing.Point(4, 25);
            this.tpDetalhes.Name = "tpDetalhes";
            this.tpDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalhes.Size = new System.Drawing.Size(792, 378);
            this.tpDetalhes.TabIndex = 1;
            this.tpDetalhes.Text = "Detalhes";
            this.tpDetalhes.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Location = new System.Drawing.Point(258, 245);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 23);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSalvar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSalvar.Location = new System.Drawing.Point(24, 245);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 23);
            this.btnSalvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            // 
            // tbTipo
            // 
            // 
            // 
            // 
            this.tbTipo.Border.Class = "TextBoxBorder";
            this.tbTipo.Border.CornerDiameter = 4;
            this.tbTipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.tbTipo.Location = new System.Drawing.Point(228, 117);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(184, 26);
            this.tbTipo.TabIndex = 5;
            // 
            // tbID
            // 
            // 
            // 
            // 
            this.tbID.Border.Class = "TextBoxBorder";
            this.tbID.Border.CornerDiameter = 4;
            this.tbID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.tbID.Location = new System.Drawing.Point(24, 43);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(137, 26);
            this.tbID.TabIndex = 4;
            // 
            // tbCor
            // 
            // 
            // 
            // 
            this.tbCor.Border.Class = "TextBoxBorder";
            this.tbCor.Border.CornerDiameter = 4;
            this.tbCor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.tbCor.Location = new System.Drawing.Point(24, 205);
            this.tbCor.Name = "tbCor";
            this.tbCor.Size = new System.Drawing.Size(388, 26);
            this.tbCor.TabIndex = 3;
            // 
            // tbNome
            // 
            // 
            // 
            // 
            this.tbNome.Border.Class = "TextBoxBorder";
            this.tbNome.Border.CornerDiameter = 4;
            this.tbNome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.tbNome.Location = new System.Drawing.Point(24, 118);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(137, 26);
            this.tbNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo do pet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cor do pet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome do pet";
            // 
            // txtIdPet
            // 
            this.txtIdPet.AutoSize = true;
            this.txtIdPet.Location = new System.Drawing.Point(21, 23);
            this.txtIdPet.Name = "txtIdPet";
            this.txtIdPet.Size = new System.Drawing.Size(64, 16);
            this.txtIdPet.TabIndex = 0;
            this.txtIdPet.Text = "ID do pet:";
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "PetView";
            this.Text = "PetView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpLista.ResumeLayout(false);
            this.tpLista.PerformLayout();
            this.tpDetalhes.ResumeLayout(false);
            this.tpDetalhes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.TabPage tpDetalhes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnProcurar;
        private DevComponents.DotNetBar.Controls.TextBoxX tbProcurar;
        private DevComponents.DotNetBar.ButtonX btnExcluir;
        private DevComponents.DotNetBar.ButtonX btnEditar;
        private DevComponents.DotNetBar.ButtonX btnNovo;
        private System.Windows.Forms.ListBox dataGridView;
        private System.Windows.Forms.Label txtIdPet;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCor;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTipo;
        private DevComponents.DotNetBar.Controls.TextBoxX tbID;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ButtonX btnSalvar;
    }
}