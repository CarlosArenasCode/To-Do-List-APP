namespace ToDoList
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms


        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.btnMostrarCompletas = new System.Windows.Forms.Button();
            this.btnMostrarPendientes = new System.Windows.Forms.Button();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.chkCompletada = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitulo.Location = new System.Drawing.Point(260, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista de Tareas";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTarea.Location = new System.Drawing.Point(30, 80);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(50, 19);
            this.lblTarea.TabIndex = 1;
            this.lblTarea.Text = "Tarea:";
            // 
            // txtTarea
            // 
            this.txtTarea.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTarea.Location = new System.Drawing.Point(110, 78);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(220, 25);
            this.txtTarea.TabIndex = 2;
            this.txtTarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDescripcion.Location = new System.Drawing.Point(30, 120);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 19);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescripcion.Location = new System.Drawing.Point(34, 145);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(296, 70);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(34, 265);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 38);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "✓ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(140, 265);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 38);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "✕ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(240, 265);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 38);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "✎ Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // lstTareas
            // 
            this.lstTareas.BackColor = System.Drawing.Color.White;
            this.lstTareas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTareas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.ItemHeight = 17;
            this.lstTareas.Location = new System.Drawing.Point(360, 80);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(400, 223);
            this.lstTareas.TabIndex = 8;
            // 
            // btnMostrarCompletas
            // 
            this.btnMostrarCompletas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnMostrarCompletas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCompletas.FlatAppearance.BorderSize = 0;
            this.btnMostrarCompletas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrarCompletas.ForeColor = System.Drawing.Color.White;
            this.btnMostrarCompletas.Location = new System.Drawing.Point(360, 320);
            this.btnMostrarCompletas.Name = "btnMostrarCompletas";
            this.btnMostrarCompletas.Size = new System.Drawing.Size(110, 35);
            this.btnMostrarCompletas.TabIndex = 9;
            this.btnMostrarCompletas.Text = "✓ Completas";
            this.btnMostrarCompletas.UseVisualStyleBackColor = false;
            this.btnMostrarCompletas.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnMostrarPendientes
            // 
            this.btnMostrarPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnMostrarPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPendientes.FlatAppearance.BorderSize = 0;
            this.btnMostrarPendientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrarPendientes.ForeColor = System.Drawing.Color.White;
            this.btnMostrarPendientes.Location = new System.Drawing.Point(480, 320);
            this.btnMostrarPendientes.Name = "btnMostrarPendientes";
            this.btnMostrarPendientes.Size = new System.Drawing.Size(110, 35);
            this.btnMostrarPendientes.TabIndex = 10;
            this.btnMostrarPendientes.Text = "⏳ Pendientes";
            this.btnMostrarPendientes.UseVisualStyleBackColor = false;
            this.btnMostrarPendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMostrarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodas.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMostrarTodas.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodas.Location = new System.Drawing.Point(600, 320);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(80, 35);
            this.btnMostrarTodas.TabIndex = 14;
            this.btnMostrarTodas.Text = "≡ Todas";
            this.btnMostrarTodas.UseVisualStyleBackColor = false;
            this.btnMostrarTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblEstado.Location = new System.Drawing.Point(30, 230);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 19);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // chkCompletada
            // 
            this.chkCompletada.AutoSize = true;
            this.chkCompletada.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkCompletada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.chkCompletada.Location = new System.Drawing.Point(110, 230);
            this.chkCompletada.Name = "chkCompletada";
            this.chkCompletada.Size = new System.Drawing.Size(104, 21);
            this.chkCompletada.TabIndex = 12;
            this.chkCompletada.Text = "Completada";
            this.chkCompletada.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(690, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 35);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "⏻ Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnMostrarTodas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.chkCompletada);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnMostrarPendientes);
            this.Controls.Add(this.btnMostrarCompletas);
            this.Controls.Add(this.lstTareas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.lblTarea);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Lista de Tareas - Gestión de Tareas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.Button btnMostrarCompletas;
        private System.Windows.Forms.Button btnMostrarPendientes;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox chkCompletada;
        private System.Windows.Forms.Button btnSalir;
    }
}

