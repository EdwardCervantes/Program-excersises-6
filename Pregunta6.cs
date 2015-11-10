public class Clase
{
 Animales a = Animales.Gato | Animales.Perro;
 Console.WriteLine(a);
 int dia = (int)Dias.Martes;.
 Console.WriteLine(dia);
 enum Animales
 {
  Gato,
  Perro,
  Cocodrilo,
  Leon,
  Oso
 };
 enum Dias : byte
 {
         Lunes = 1,
         Martes,
  Miercoles
 }
}