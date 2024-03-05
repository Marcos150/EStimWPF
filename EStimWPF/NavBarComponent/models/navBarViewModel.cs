namespace EStimWPF.NavBarComponent.models
{
    internal class navBarViewModel
    {
        private string link1, link2, link3, link4, link5, link6;

        public navBarViewModel (string link1, string link2, string link3, string link4, string link5, string link6) {
            this.Link1 = link1;
            this.Link2 = link2;
            this.Link3 = link3;
            this.Link4 = link4;
            this.Link5 = link5;
            this.Link6 = link6;
        }

        public string Link1 { get => link1; set => link1 = value; }
        public string Link2 { get => link2; set => link2 = value; }
        public string Link3 { get => link3; set => link3 = value; }
        public string Link4 { get => link4; set => link4 = value; }
        public string Link5 { get => link5; set => link5 = value; }
        public string Link6 { get => link6; set => link6 = value; }
    }
}
