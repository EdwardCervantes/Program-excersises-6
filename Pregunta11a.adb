With Ada.Text_IO; Use Ada.Text_IO;  
With Ada.Integer_Text_IO; Use Ada.Integer_Text_IO;
procedure Program is
flotante : float := 22.41;
caracter : character := 'M';
cadena : String := "string en Ada!";
numero : integer := 214685;
boleano : boolean := TRUE;
begin
 put("Hello World");
  flotante:=caracter; //error expected type "Standard.Float"
  boleano:=numero;//error expected type "Standard.Boolean"
  numero:=boleano;//error expected type "Standard.Integer"
  caracter:=numero;//error expected type "Standard.Character"
  numero:=flotante;//error expected type "Standard.Integer"
  cadena:=caracter;//error expected type "Standard.String"
  boleano:=character;//error expected type "Standard.Boolean"
  caracter:=cadena;//error expected type "Standard.Character"
  flotante:=numero;//error expected type "Standard.Float"
end Program;