namespace BeeUI
{
    partial class frmBeeUI
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
            this.lvBees = new System.Windows.Forms.ListView();
            this.clmBee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHealth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIsDead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDamage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvBees
            // 
            this.lvBees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmBee,
            this.clmHealth,
            this.clmIsDead});
            this.lvBees.FullRowSelect = true;
            this.lvBees.HideSelection = false;
            this.lvBees.Location = new System.Drawing.Point(12, 12);
            this.lvBees.Name = "lvBees";
            this.lvBees.Size = new System.Drawing.Size(788, 437);
            this.lvBees.TabIndex = 0;
            this.lvBees.UseCompatibleStateImageBehavior = false;
            this.lvBees.View = System.Windows.Forms.View.Details;
            // 
            // clmBee
            // 
            this.clmBee.Text = "Bee";
            this.clmBee.Width = 112;
            // 
            // clmHealth
            // 
            this.clmHealth.Text = "Health";
            this.clmHealth.Width = 137;
            // 
            // clmIsDead
            // 
            this.clmIsDead.Text = "Is Dead?";
            this.clmIsDead.Width = 168;
            // 
            // btnDamage
            // 
            this.btnDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDamage.Location = new System.Drawing.Point(725, 455);
            this.btnDamage.Name = "btnDamage";
            this.btnDamage.Size = new System.Drawing.Size(75, 23);
            this.btnDamage.TabIndex = 1;
            this.btnDamage.Text = "Damage";
            this.btnDamage.UseVisualStyleBackColor = true;
            this.btnDamage.Click += new System.EventHandler(this.btnDamage_Click);
            // 
            // frmBeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 488);
            this.Controls.Add(this.btnDamage);
            this.Controls.Add(this.lvBees);
            this.Name = "frmBeeUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBeeUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvBees;
        private System.Windows.Forms.ColumnHeader clmBee;
        private System.Windows.Forms.ColumnHeader clmHealth;
        private System.Windows.Forms.ColumnHeader clmIsDead;
        private System.Windows.Forms.Button btnDamage;
    }
}

