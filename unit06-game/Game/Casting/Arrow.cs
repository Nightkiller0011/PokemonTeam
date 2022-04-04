using System;

namespace Unit06.Game.Casting
{
    public class Arrow : Actor
    {
        private string _message = "^";
        public Arrow()
        {

            SetFontSize(Constants.FONT_SIZE);
            setFightClass("arrow");
            SetImage("Assats/Assets/arrow2.png");
            SetText(_message);
            SetColor(Constants.GRAY);
        }
    }

}