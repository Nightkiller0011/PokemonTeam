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
            SetText(_message);
            SetColor(Constants.GRAY);
        }
    }

}