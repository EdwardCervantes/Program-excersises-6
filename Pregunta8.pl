%data = ('Homero' => 45, 'Lisa' => 30, 'Bart' => 40);

print "$data{'Homero'}\n";
print "$data{'Lisa'}\n";
print "$data{'Bart'}\n";

@keys = keys %data;
$size = @keys;
print "Tama�o 1:  es $size\n";

$data{'Lisa'} = 55;
@keys = keys %data;
$size = @keys;
print "Tama�o 2:  es $size\n";

$data{'March'} = 15;
@keys = keys %data;
$size = @keys;
print "Tama�o 3:  es $size\n";