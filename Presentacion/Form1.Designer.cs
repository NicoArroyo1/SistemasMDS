namespace SistemasMDS.Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.btnCtrlHerramientas = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCtrlMateriales = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.AutoSize = true;
            this.btnHerramientas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHerramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerramientas.Location = new System.Drawing.Point(3, 3);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(317, 65);
            this.btnHerramientas.TabIndex = 1;
            this.btnHerramientas.Text = "ABM - Herramientas";
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnMateriales
            // 
            this.btnMateriales.AutoSize = true;
            this.btnMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriales.Location = new System.Drawing.Point(326, 3);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(317, 65);
            this.btnMateriales.TabIndex = 2;
            this.btnMateriales.Text = "ABM - Materiales";
            this.btnMateriales.UseVisualStyleBackColor = true;
            this.btnMateriales.Click += new System.EventHandler(this.btnMateriales_Click);
            // 
            // btnCtrlHerramientas
            // 
            this.btnCtrlHerramientas.AutoSize = true;
            this.btnCtrlHerramientas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCtrlHerramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtrlHerramientas.Location = new System.Drawing.Point(649, 3);
            this.btnCtrlHerramientas.Name = "btnCtrlHerramientas";
            this.btnCtrlHerramientas.Size = new System.Drawing.Size(317, 65);
            this.btnCtrlHerramientas.TabIndex = 3;
            this.btnCtrlHerramientas.Text = "Control Herramientas";
            this.btnCtrlHerramientas.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCtrlMateriales
            // 
            this.btnCtrlMateriales.AutoSize = true;
            this.btnCtrlMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCtrlMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtrlMateriales.Location = new System.Drawing.Point(972, 3);
            this.btnCtrlMateriales.Name = "btnCtrlMateriales";
            this.btnCtrlMateriales.Size = new System.Drawing.Size(319, 65);
            this.btnCtrlMateriales.TabIndex = 7;
            this.btnCtrlMateriales.Text = "Control Materlales";
            this.btnCtrlMateriales.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnCtrlMateriales, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHerramientas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCtrlHerramientas, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMateriales, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1294, 71);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1294, 762);
            this.splitContainer2.SplitterDistance = 71;
            this.splitContainer2.TabIndex = 10;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 762);
            this.Controls.Add(this.splitContainer2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas MDS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Button btnCtrlHerramientas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btnCtrlMateriales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

