using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMiningHomework
{
    public class DataItem
    {
        [DataObjectField(false)]
        public double[] Attributes { get; set; }

        [DisplayName("Class")]
        public double Class { get; set; }

        [DisplayName("Predicted Class")]
        public double PredictedClass { get; set; }

        public DataItem(double[] attributes, double @class, int predictedClass = -1)
        {
            Attributes = attributes;
            Class = @class;
            PredictedClass = predictedClass;
        }
        
    }
}