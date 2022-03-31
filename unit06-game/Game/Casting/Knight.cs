using System;

namespace Unit06.Game.Casting
{
    public class Knight : Actor
    {
        private string _message = "/";
        public Knight()
        {

            SetFontSize(Constants.FONT_SIZE);

            SetText(_message);
            SetColor(Constants.SILVER);
        }
    }
}