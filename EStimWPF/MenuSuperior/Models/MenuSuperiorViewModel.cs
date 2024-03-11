namespace EStimWPF.models
{
    internal class MenuSuperiorViewModel
    {
        private string logoWeb;
        private string elemento1, elemento2, elemento3, elemento4;

        public MenuSuperiorViewModel(string logoWeb, string elemento1, string elemento2, string elemento3, string elemento4)
        {
            this.logoWeb = logoWeb;
            this.elemento1 = elemento1;
            this.elemento2 = elemento2;
            this.elemento3 = elemento3;
            this.elemento4 = elemento4;
        }

        public string LogoWeb { get => logoWeb; set => logoWeb = value; }
        public string Elemento1 { get => elemento1; set => elemento1 = value; }
        public string Elemento2 { get => elemento2; set => elemento2 = value; }
        public string Elemento3 { get => elemento3; set => elemento3 = value; }
        public string Elemento4 { get => elemento4; set => elemento4 = value; }

    }
}
