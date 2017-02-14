﻿using System;
using WebFormsMvp;
using WebFormsMvp.Web;
using ZobShop.ModelViewPresenter.Product.Details;

namespace ZobShop.Web.Product
{
    [PresenterBinding(typeof(ProductDetailsPresenter))]
    public partial class ProductDetails : MvpPage<ProductDetailsViewModel>, IProductDetailsView
    {
        private const string SqlCommandTemplate = "SELECT * FROM PRODUCTRATINGS WHERE PRODUCTID={0}";
        private static string SqlCommand;

        public event EventHandler<ProductDetailsEventArgs> MyProductDetails;

        private const string QueryId = "id";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(this.Request.QueryString[QueryId]);

                var args = new ProductDetailsEventArgs(id);

                this.MyProductDetails?.Invoke(this, args);

                SqlCommand = string.Format(SqlCommandTemplate, id);
            }
            catch (Exception)
            {
                this.ErrorLabel.Text = "Please provide an id";
                return;
            }

            this.SqlDataSourceComments.SelectCommand = SqlCommand;
            this.SqlDataSourceComments.DataBind();
            // TODO: Bind to model
        }

        protected void Rate_OnClick(object sender, EventArgs e)
        {


            this.SqlDataSourceComments.DataBind();
        }
    }
}