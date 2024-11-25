namespace product
{
    partial class productlist
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
            this.BACK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.SEARCH_PRODUCT = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // BACK
            // 
            this.BACK.Font = new System.Drawing.Font("Segoe Marker", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.Location = new System.Drawing.Point(886, 334);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(93, 54);
            this.BACK.TabIndex = 0;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "VIEW PRODUCT LIST IN DISPLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Vijaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(497, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(185, 29);
            this.search.TabIndex = 3;
            // 
            // SEARCH_PRODUCT
            // 
            this.SEARCH_PRODUCT.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_PRODUCT.Location = new System.Drawing.Point(731, 17);
            this.SEARCH_PRODUCT.Name = "SEARCH_PRODUCT";
            this.SEARCH_PRODUCT.Size = new System.Drawing.Size(164, 37);
            this.SEARCH_PRODUCT.TabIndex = 4;
            this.SEARCH_PRODUCT.Text = "SEARCH_PRODUCT";
            this.SEARCH_PRODUCT.UseVisualStyleBackColor = true;
            this.SEARCH_PRODUCT.Click += new System.EventHandler(this.SEARCH_PRODUCT_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(27, 88);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(844, 307);
            this.data.TabIndex = 5;
            // 
            // productlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 435);
            this.Controls.Add(this.data);
            this.Controls.Add(this.SEARCH_PRODUCT);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BACK);
            this.Name = "productlist";
            this.Text = "productlist";
            this.Load += new System.EventHandler(this.productlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button SEARCH_PRODUCT;
        private System.Windows.Forms.DataGridView data;
    }
}