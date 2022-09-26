namespace MAQUINATURING
{

    class Operacion
    {
        public Operacion(Movimientos movimiento, Acciones accion)
        {
            Movimiento = movimiento;
            Accion = accion;
        }

        public Movimientos Movimiento { get; set; }

        public Acciones Accion { get; set; }

        public char CaracterPerteneceAMov { get; set; }

        public char AccionCaracter { get; set; }
    }
    enum Movimientos
    {
        MoverIzquierda = 3,
        MoverDerecha = 4,
        MoverUnoPorIzquierda = 1,
        MoverUnoPorDerecha = 2,
        Mantenerse = 0
    }

    enum Acciones
    {
        ReemplazarPorBlanco = 0, // Poner el triangulito
        ReemplazarPorUnCaracter = 1,
        Sobreescribir = 2
    }
}
