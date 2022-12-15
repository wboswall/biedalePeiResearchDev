#include <stdio.h>
#include <stdlib.h>
int radius, area;
int main()
{
    printf("Enter radius (i.e. 10): ");
    scanf("%d", &radius);
    area=(int) (3.14159 *radius * radius);
    printf("\n\nArea=%d\n",area);
    system ("pause");
    return 0;
}
