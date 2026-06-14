namespace GestaoDeEquipamentos.ConsoleApp.Utilidades;

public static class GeradorIds
{
    private static int contadorIdsEquipamentos = 1;

    private static int contadorIdsChamados = 1;

    public static int ObterIdsEquipamentos()
    {
        return contadorIdsEquipamentos++;
    }

    public static int ObterIdsChamados()
    {
        return contadorIdsChamados++;
    }
}