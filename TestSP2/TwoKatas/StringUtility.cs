namespace TwoKatas
{
    public class StringUtility
    {
        private string text;
        public StringUtility()
        {
        
        }

        public string reverse(string inputString)
        {
            var chars = inputString.ToCharArray();
            var reversedText = String.Empty;

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                reversedText += chars[i];
            }

            return reversedText;
        }

        public string capitalize(string inputString)
        {
            var chars = inputString.ToCharArray();
            var capitalizedText = String.Empty;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'a' && chars[i] <= 'z')
                {
                    chars[i] = (char)((int)chars[i] - 32);
                    capitalizedText += chars[i];
                } else
                {
                    capitalizedText += chars[i];
                }
            }
            return capitalizedText;
        }

        public string lowercase(string inputString)
        {
            var chars = inputString.ToCharArray();
            var capitalizedText = String.Empty;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = (char)((int)chars[i] + 32);
                    capitalizedText += chars[i];
                }
                else
                {
                    capitalizedText += chars[i];
                }
            }
            return capitalizedText;
        }

        public void setText(string text)
        {
            this.text = text;
        }

        public string getText()
        {
            return this.text;
        }

    }
}