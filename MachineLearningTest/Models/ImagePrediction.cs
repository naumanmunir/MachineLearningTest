using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningTest.Models
{
    public class ImagePrediction : ImageData
    {
        public float[] Score;

        public string PredictedLabelValue;
    }
}
