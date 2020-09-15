using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnmaskedApp.Shared.Model
{
    public class StoryElement
    {
        public enum Types { TEXT, IMAGE, CUSTOM, EFFECT }
        public enum Effects { TRRNG, GAME_OVER }

        public Types Type { get; set; }
        public string Text { get; set; }
        public int ImageNumber { get; set; } = 1;
        public string Url { get; set; }
        public Effects Effect { get; set; }

        public StoryElement(Types type)
        {
            Type = type;
        }

        static readonly string SeparatorString = "|";
        public static string Serialize(StoryElement element)
        {
            StringBuilder outputBuilder = new StringBuilder((int)element.Type + SeparatorString);
            switch (element.Type)
            {
                case Types.TEXT:
                    outputBuilder.Append(element.Text);
                    break;
                case Types.IMAGE:
                    outputBuilder.Append(element.ImageNumber.ToString());
                    break;
                case Types.CUSTOM:
                    outputBuilder.Append(element.Url);
                    break;
                case Types.EFFECT:
                    outputBuilder.Append((int)element.Effect);
                    break;
            }

            return outputBuilder.ToString();
        }

        public static StoryElement TryDeserialize(string data)
        {
            //throw new NotImplementedException();
            var output = data.Split(SeparatorString);
            if (output.Length != 2)
                throw new Exception("Invalid data parsed - it should contain " + SeparatorString + " separator char. Value:" + data);

            int enumNumber = -1;
            if (!int.TryParse(output[0], out enumNumber))
                throw new Exception("Invalid first data - Not a valid integer number. Value:" + data);

            Types type = (Types)enumNumber;
            StoryElement element = new StoryElement(type);

            switch (type)
            {
                case Types.TEXT:
                    element.Text = output[1];
                    break;
                case Types.IMAGE:
                    {
                        int imageNum = -1;
                        if (!int.TryParse(output[1], out imageNum))
                            throw new Exception("Invalid second data - Not a valid integer number. Value:" + data);

                        element.ImageNumber = imageNum;
                    }
                    break;
                case Types.CUSTOM:
                    element.Url = output[1];
                    break;
                case Types.EFFECT:
                    {
                        int effectNum = -1;
                        if (!int.TryParse(output[1], out effectNum))
                            throw new Exception("Invalid second data - Not a valid integer number. Value:" + data);

                        element.Effect = (Effects)effectNum;
                    }
                    break;
            }

            return element;
        }

        public static string SoundFileName(Effects effect)
        { 
            switch (effect)
            {
                case Effects.TRRNG:
                    return "Metal Gear Alert! Sound Effect.mp3";    
                case Effects.GAME_OVER:
                    return "Metal Gear Game Over Sound Effect.mp3";
                default:
                    break;
            }

            throw new Exception("Invalid sound file name for effect:" + effect.ToString());
        }
    }
}
