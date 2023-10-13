﻿namespace LeitorAEJ.AFD.Portaria_1510;

public class Trailer1510
{
    public string? Noves { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico, Dado: = 999999999*/
    public string? QtdRegTipo2 { get; set; } /*Tamanho: 9, Posição: 10 a 18, Tipo: numérico*/
    public string? QtdRegTipo3 { get; set; } /*Tamanho: 9, Posição: 19 a 27, Tipo: numérico*/
    public string? QtdRegTipo4 { get; set; } /*Tamanho: 9, Posição: 28 a 36, Tipo: numérico*/
    public string? QtdRegTipo5 { get; set; } /*Tamanho: 9, Posição: 37 a 45, Tipo: numérico*/
    public string? QtdRegTipo6 { get; set; } /*Tamanho: 9, Posição: 46 a 54, Tipo: numérico*/
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição 55 a 55, Tipo: numérico, Dado: = 9*/

    public static List<Trailer1510> Trailer1510List { get; set; } = new();
    public static void GetTrailer(string linhaTrailer)
    {
        Trailer1510 trailer = new()
        {
            Noves = linhaTrailer.Substring(0, 9).Trim(),
            QtdRegTipo2 = linhaTrailer.Substring(9, 9).Trim(),
            QtdRegTipo3 = linhaTrailer.Substring(18, 9).Trim(),
            QtdRegTipo4 = linhaTrailer.Substring(27, 9).Trim(),
            QtdRegTipo5 = linhaTrailer.Substring(36, 9).Trim(),
            QtdRegTipo6 = linhaTrailer.Substring(45, 9).Trim(),
            TpRegistro = linhaTrailer.Substring(54, 1).Trim()
        };
        Trailer1510List.Add(trailer);
    }
}
