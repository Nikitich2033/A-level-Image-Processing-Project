using Microsoft.ML.Data;

namespace project
{
    class ImageData
    {
        [LoadColumn(0)]
        public string ImagePath;

        [LoadColumn(1)]
        public string Label;
    }
}

