namespace Book_Serilazation
{
    partial class Form1
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
            this.Bookid = new System.Windows.Forms.Label();
            this.Bookname = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BId = new System.Windows.Forms.TextBox();
            this.Author_name = new System.Windows.Forms.TextBox();
            this.Price_Book = new System.Windows.Forms.TextBox();
            this.Book_name = new System.Windows.Forms.TextBox();
            this.BinaryWrite = new System.Windows.Forms.Button();
            this.BinaryRead = new System.Windows.Forms.Button();
            this.XMLWrite = new System.Windows.Forms.Button();
            this.XMLRead = new System.Windows.Forms.Button();
            this.SOAPWrite = new System.Windows.Forms.Button();
            this.SOAPREAD = new System.Windows.Forms.Button();
            this.JSONWrite = new System.Windows.Forms.Button();
            this.JSONRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bookid
            // 
            this.Bookid.AutoSize = true;
            this.Bookid.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookid.Location = new System.Drawing.Point(51, 35);
            this.Bookid.Name = "Bookid";
            this.Bookid.Size = new System.Drawing.Size(73, 19);
            this.Bookid.TabIndex = 0;
            this.Bookid.Text = "Book ID :";
            // 
            // Bookname
            // 
            this.Bookname.AutoSize = true;
            this.Bookname.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookname.Location = new System.Drawing.Point(51, 85);
            this.Bookname.Name = "Bookname";
            this.Bookname.Size = new System.Drawing.Size(99, 19);
            this.Bookname.TabIndex = 1;
            this.Bookname.Text = "Book Name :";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(51, 136);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(113, 19);
            this.author.TabIndex = 2;
            this.author.Text = "Author Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price :";
            // 
            // BId
            // 
            this.BId.Location = new System.Drawing.Point(201, 35);
            this.BId.Multiline = true;
            this.BId.Name = "BId";
            this.BId.Size = new System.Drawing.Size(100, 20);
            this.BId.TabIndex = 4;
            // 
            // Author_name
            // 
            this.Author_name.Location = new System.Drawing.Point(201, 136);
            this.Author_name.Name = "Author_name";
            this.Author_name.Size = new System.Drawing.Size(100, 20);
            this.Author_name.TabIndex = 5;
            // 
            // Price_Book
            // 
            this.Price_Book.Location = new System.Drawing.Point(201, 186);
            this.Price_Book.Name = "Price_Book";
            this.Price_Book.Size = new System.Drawing.Size(100, 20);
            this.Price_Book.TabIndex = 6;
            // 
            // Book_name
            // 
            this.Book_name.Location = new System.Drawing.Point(201, 85);
            this.Book_name.Name = "Book_name";
            this.Book_name.Size = new System.Drawing.Size(100, 20);
            this.Book_name.TabIndex = 7;
            // 
            // BinaryWrite
            // 
            this.BinaryWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryWrite.Location = new System.Drawing.Point(406, 35);
            this.BinaryWrite.Name = "BinaryWrite";
            this.BinaryWrite.Size = new System.Drawing.Size(111, 48);
            this.BinaryWrite.TabIndex = 8;
            this.BinaryWrite.Text = "Binary Write";
            this.BinaryWrite.UseVisualStyleBackColor = true;
            this.BinaryWrite.Click += new System.EventHandler(this.BinaryWrite_Click);
            // 
            // BinaryRead
            // 
            this.BinaryRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryRead.Location = new System.Drawing.Point(530, 35);
            this.BinaryRead.Name = "BinaryRead";
            this.BinaryRead.Size = new System.Drawing.Size(111, 48);
            this.BinaryRead.TabIndex = 9;
            this.BinaryRead.Text = "Binary Read";
            this.BinaryRead.UseVisualStyleBackColor = true;
            this.BinaryRead.Click += new System.EventHandler(this.BinaryRead_Click);
            // 
            // XMLWrite
            // 
            this.XMLWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XMLWrite.Location = new System.Drawing.Point(406, 108);
            this.XMLWrite.Name = "XMLWrite";
            this.XMLWrite.Size = new System.Drawing.Size(111, 48);
            this.XMLWrite.TabIndex = 10;
            this.XMLWrite.Text = "XML Write";
            this.XMLWrite.UseVisualStyleBackColor = true;
            this.XMLWrite.Click += new System.EventHandler(this.XMLWrite_Click);
            // 
            // XMLRead
            // 
            this.XMLRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XMLRead.Location = new System.Drawing.Point(530, 107);
            this.XMLRead.Name = "XMLRead";
            this.XMLRead.Size = new System.Drawing.Size(111, 48);
            this.XMLRead.TabIndex = 11;
            this.XMLRead.Text = "XML Read";
            this.XMLRead.UseVisualStyleBackColor = true;
            this.XMLRead.Click += new System.EventHandler(this.XMLRead_Click);
            // 
            // SOAPWrite
            // 
            this.SOAPWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOAPWrite.Location = new System.Drawing.Point(406, 171);
            this.SOAPWrite.Name = "SOAPWrite";
            this.SOAPWrite.Size = new System.Drawing.Size(111, 48);
            this.SOAPWrite.TabIndex = 12;
            this.SOAPWrite.Text = "SOAP Write";
            this.SOAPWrite.UseVisualStyleBackColor = true;
            this.SOAPWrite.Click += new System.EventHandler(this.SOAPWrite_Click);
            // 
            // SOAPREAD
            // 
            this.SOAPREAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOAPREAD.Location = new System.Drawing.Point(530, 171);
            this.SOAPREAD.Name = "SOAPREAD";
            this.SOAPREAD.Size = new System.Drawing.Size(111, 48);
            this.SOAPREAD.TabIndex = 13;
            this.SOAPREAD.Text = "SOAP Read";
            this.SOAPREAD.UseVisualStyleBackColor = true;
            this.SOAPREAD.Click += new System.EventHandler(this.SOAPREAD_Click);
            // 
            // JSONWrite
            // 
            this.JSONWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JSONWrite.Location = new System.Drawing.Point(406, 241);
            this.JSONWrite.Name = "JSONWrite";
            this.JSONWrite.Size = new System.Drawing.Size(111, 48);
            this.JSONWrite.TabIndex = 14;
            this.JSONWrite.Text = "JSON Write";
            this.JSONWrite.UseVisualStyleBackColor = true;
            this.JSONWrite.Click += new System.EventHandler(this.JSONWrite_Click);
            // 
            // JSONRead
            // 
            this.JSONRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JSONRead.Location = new System.Drawing.Point(530, 241);
            this.JSONRead.Name = "JSONRead";
            this.JSONRead.Size = new System.Drawing.Size(111, 48);
            this.JSONRead.TabIndex = 15;
            this.JSONRead.Text = "JSON Read";
            this.JSONRead.UseVisualStyleBackColor = true;
            this.JSONRead.Click += new System.EventHandler(this.JSONRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JSONRead);
            this.Controls.Add(this.JSONWrite);
            this.Controls.Add(this.SOAPREAD);
            this.Controls.Add(this.SOAPWrite);
            this.Controls.Add(this.XMLRead);
            this.Controls.Add(this.XMLWrite);
            this.Controls.Add(this.BinaryRead);
            this.Controls.Add(this.BinaryWrite);
            this.Controls.Add(this.Book_name);
            this.Controls.Add(this.Price_Book);
            this.Controls.Add(this.Author_name);
            this.Controls.Add(this.BId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.author);
            this.Controls.Add(this.Bookname);
            this.Controls.Add(this.Bookid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bookid;
        private System.Windows.Forms.Label Bookname;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BId;
        private System.Windows.Forms.TextBox Author_name;
        private System.Windows.Forms.TextBox Price_Book;
        private System.Windows.Forms.TextBox Book_name;
        private System.Windows.Forms.Button BinaryWrite;
        private System.Windows.Forms.Button BinaryRead;
        private System.Windows.Forms.Button XMLWrite;
        private System.Windows.Forms.Button XMLRead;
        private System.Windows.Forms.Button SOAPWrite;
        private System.Windows.Forms.Button SOAPREAD;
        private System.Windows.Forms.Button JSONWrite;
        private System.Windows.Forms.Button JSONRead;
    }
}

