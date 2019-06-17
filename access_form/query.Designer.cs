namespace access_form
{
    partial class query
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(query));
            this.sqloukDataSet = new access_form.sqloukDataSet();
            this.getDeatailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDeatailsTableAdapter = new access_form.sqloukDataSetTableAdapters.GetDeatailsTableAdapter();
            this.tableAdapterManager = new access_form.sqloukDataSetTableAdapters.TableAdapterManager();
            this.getDeatailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.getDeatailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.getDeatailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sqloukDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDeatailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDeatailsBindingNavigator)).BeginInit();
            this.getDeatailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDeatailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sqloukDataSet
            // 
            this.sqloukDataSet.DataSetName = "sqloukDataSet";
            this.sqloukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getDeatailsBindingSource
            // 
            this.getDeatailsBindingSource.DataMember = "GetDeatails";
            this.getDeatailsBindingSource.DataSource = this.sqloukDataSet;
            // 
            // getDeatailsTableAdapter
            // 
            this.getDeatailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carsTableAdapter = null;
            this.tableAdapterManager.con_car_shotTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.hitsTableAdapter = null;
            this.tableAdapterManager.shotTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = access_form.sqloukDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // getDeatailsBindingNavigator
            // 
            this.getDeatailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.getDeatailsBindingNavigator.BindingSource = this.getDeatailsBindingSource;
            this.getDeatailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.getDeatailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.getDeatailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.getDeatailsBindingNavigatorSaveItem});
            this.getDeatailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.getDeatailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.getDeatailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.getDeatailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.getDeatailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.getDeatailsBindingNavigator.Name = "getDeatailsBindingNavigator";
            this.getDeatailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.getDeatailsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.getDeatailsBindingNavigator.TabIndex = 0;
            this.getDeatailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // getDeatailsBindingNavigatorSaveItem
            // 
            this.getDeatailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.getDeatailsBindingNavigatorSaveItem.Enabled = false;
            this.getDeatailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("getDeatailsBindingNavigatorSaveItem.Image")));
            this.getDeatailsBindingNavigatorSaveItem.Name = "getDeatailsBindingNavigatorSaveItem";
            this.getDeatailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.getDeatailsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // getDeatailsDataGridView
            // 
            this.getDeatailsDataGridView.AutoGenerateColumns = false;
            this.getDeatailsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.getDeatailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getDeatailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.getDeatailsDataGridView.DataSource = this.getDeatailsBindingSource;
            this.getDeatailsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.getDeatailsDataGridView.Name = "getDeatailsDataGridView";
            this.getDeatailsDataGridView.Size = new System.Drawing.Size(445, 248);
            this.getDeatailsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id car";
            this.dataGridViewTextBoxColumn1.HeaderText = "id car";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "size of";
            this.dataGridViewTextBoxColumn2.HeaderText = "size of";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "num of hits";
            this.dataGridViewTextBoxColumn3.HeaderText = "num of hits";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "avarge";
            this.dataGridViewTextBoxColumn4.HeaderText = "avarge";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "auto id";
            this.dataGridViewTextBoxColumn5.HeaderText = "auto id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(612, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "query";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::access_form.Properties.Resources.blank;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getDeatailsDataGridView);
            this.Controls.Add(this.getDeatailsBindingNavigator);
            this.Name = "query";
            this.Text = "query";
            this.Load += new System.EventHandler(this.Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sqloukDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDeatailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDeatailsBindingNavigator)).EndInit();
            this.getDeatailsBindingNavigator.ResumeLayout(false);
            this.getDeatailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDeatailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sqloukDataSet sqloukDataSet;
        private System.Windows.Forms.BindingSource getDeatailsBindingSource;
        private sqloukDataSetTableAdapters.GetDeatailsTableAdapter getDeatailsTableAdapter;
        private sqloukDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator getDeatailsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton getDeatailsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView getDeatailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
    }
}