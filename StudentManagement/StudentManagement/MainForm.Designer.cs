namespace StudentManagement
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Filiere = new System.Windows.Forms.TextBox();
            this.Vider = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Chercher = new System.Windows.Forms.Button();
            this.Afficher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filiere";
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(311, 78);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(100, 20);
            this.Code.TabIndex = 4;
            this.Code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(311, 169);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(100, 20);
            this.Prenom.TabIndex = 5;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(311, 117);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 20);
            this.Nom.TabIndex = 6;
            // 
            // Filiere
            // 
            this.Filiere.Location = new System.Drawing.Point(311, 224);
            this.Filiere.Name = "Filiere";
            this.Filiere.Size = new System.Drawing.Size(100, 20);
            this.Filiere.TabIndex = 7;
            // 
            // Vider
            // 
            this.Vider.Location = new System.Drawing.Point(663, 76);
            this.Vider.Name = "Vider";
            this.Vider.Size = new System.Drawing.Size(75, 23);
            this.Vider.TabIndex = 8;
            this.Vider.Text = "Vider";
            this.Vider.UseVisualStyleBackColor = true;
            this.Vider.Click += new System.EventHandler(this.Vider_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(663, 124);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 9;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(663, 169);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 10;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(663, 214);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 11;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Chercher
            // 
            this.Chercher.Location = new System.Drawing.Point(663, 256);
            this.Chercher.Name = "Chercher";
            this.Chercher.Size = new System.Drawing.Size(75, 23);
            this.Chercher.TabIndex = 12;
            this.Chercher.Text = "Chercher";
            this.Chercher.UseVisualStyleBackColor = true;
            this.Chercher.Click += new System.EventHandler(this.Chercher_Click);
            // 
            // Afficher
            // 
            this.Afficher.Location = new System.Drawing.Point(408, 379);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(75, 23);
            this.Afficher.TabIndex = 13;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = true;
            this.Afficher.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.Chercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Vider);
            this.Controls.Add(this.Filiere);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Filiere;
        private System.Windows.Forms.Button Vider;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Chercher;
        private System.Windows.Forms.Button Afficher;
    }
}

