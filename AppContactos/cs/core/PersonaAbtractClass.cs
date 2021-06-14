namespace AppContactos.cs.core
{
    class PersonaAbtractClass
    {
        private string nombres;
        private string apellidos;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string NombreCompleto => this.Nombres + " " + this.Apellidos;
    }
}
