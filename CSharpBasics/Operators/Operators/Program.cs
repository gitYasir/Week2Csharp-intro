#region
int x = 5;
int y = 5;

int postfix = x++;
int prefix = ++y;

Console.WriteLine( $"postfix: {postfix} -- prefix: {prefix}" );

/*
* The for loop shows that it makes no difference if you use a prefix or postfix
* increment or decrement if they are standalone
*/
for ( int i = 0; i < 5; i++ ) {
    Console.WriteLine( i );
    }
#endregion

