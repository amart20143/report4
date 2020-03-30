﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace group4LICA
{
    public partial class AddNewItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ValidateInput(); //calls other validation
        }

        private void ValidateInput() {

            ValidateText();
            ValidateNumbers();
            ValidateImage();

        }

        private void ValidateImage() {

            HttpPostedFile theFile = fileImage.PostedFile;
            if (!theFile.FileName.Contains(".png")||!theFile.FileName.Contains(".jpg")) {
                lblImageError.Text = "File must be a .png or .jpg file";
            }
        }

        private void ValidateText() {
            String itemName = txtItemName.Text;
            String itemDescription = txtDesc.Text;

            if (itemName == "") {
                lblNameError.Text = "**Item Name cannot be empty";
            }
            if (itemDescription=="") {
                lblDescriptionError.Text = "**Item needs a description";
            }

        }
        private void ValidateNumbers() {

            try
            {
                Double startingPrice = Double.Parse(txtStartingPrice.Text);
                if (startingPrice <= 0) { lblStartingPriceError.Text = "**Starting price cannot be equal to or less than zero. "; }
            }
            catch (Exception e) {
                lblStartingPriceError.Text+=("**Please format price as \"x.yz\"");
            }

            try
            {
                int bidLength = int.Parse(txtBidLength.Text);
                if (bidLength <= 0) { lblStartingPriceError.Text = "**Bid length cannot be equal to or less than zero. Must be less than 10. "; }
            }
            catch (Exception e)
            {
                lblStartingPriceError.Text += ("**Please format bid length as a single number less than or equal to 10 ");
            }

            try
            {
                double shippingHeight = double.Parse(txtShipHeight.Text);
                if (shippingHeight < 0) { lblShipHeightError.Text = "**Please enter an integer greater than zero "; }
            }
            catch (Exception e) {
                lblShipHeightError.Text += "**Please enter the number as \"x.yz\"";
            }

            try
            {
                double shippingLength = double.Parse(txtShipLength.Text);
                if (shippingLength < 0) { lblShipLengthError.Text = "**Please enter an integer greater than zero "; }
            }
            catch (Exception e)
            {
                lblShipLengthError.Text += "**Please enter the number as \"x.yz\"";
            }

            try
            {
                double shippingDepth = double.Parse(txtShipDepth.Text);
                if (shippingDepth < 0) { lblShipDepthError.Text = "**Please enter an integer greater than zero "; }
            }
            catch (Exception e)
            {
                lblShipDepthError.Text += "**Please enter the number as \"x.yz\"";
            }

            try
            {
                double shippingWeight = double.Parse(txtShipWeight.Text);
                if (shippingWeight <= 0) { lblShipWeightError.Text = "**Please enter an integer greater than zero "; }
            }
            catch (Exception e)
            {
                lblShipWeightError.Text += "**Please enter the number as \"x.yz\"";
            }

            try
            {
                double shippingCost = double.Parse(txtShipWeight.Text);
                if (shippingCost <= 0) { lblShipCostError.Text = "**Please enter an integer greater than zero "; }
            }
            catch (Exception e)
            {
                lblShipCostError.Text += "**Please enter the number as \"x.yz\"";
            }

        }
    }
}
