using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace project
{
    class ImagePrediction : ImageData
    {
        public float[] Score;

        public string PredictedLabelValue;
    }
}


