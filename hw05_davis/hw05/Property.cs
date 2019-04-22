namespace hw05 {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Summary description for Property
    /// </summary>
    public class Property
    {
        private Double listPrice;

        public Double ListPrice
        {
            get { return listPrice; }
            set { listPrice = value; }
        }
        private Double sqFeet;

        public Double SqFeet
        {
            get { return sqFeet; }
            set { sqFeet = value; }
        }
        private double beds;

        public double Beds
        {
            get { return beds; }
            set { beds = value; }
        }
        private double baths;

        public double Baths
        {
            get { return baths; }
            set { baths = value; }
        }
        private double yearBuilt;

        public double YearBuilt
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }
        }

        private double pricePerSqFoot;

        public double PricePerSqFoot
        {
            get { return pricePerSqFoot; }
            set { pricePerSqFoot = value; }
        }


        public Property(Double price, Double sqFeet, double beds, double baths, double year)
        {
            this.listPrice = price;
            this.sqFeet = sqFeet;
            this.beds = beds;
            this.baths = baths;
            this.yearBuilt = year;
            pricePerSqFoot = this.listPrice / this.sqFeet;
        }

        public string toString()
        {
            return $"{ListPrice:C}" + "\t" + sqFeet + "\t" + beds + "\t" + baths + "\t" + yearBuilt + "\t" + $"{pricePerSqFoot:C}" + "\n";
        }

    }
}