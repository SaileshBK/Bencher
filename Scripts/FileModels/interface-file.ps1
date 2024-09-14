param (
    [string]$InterfaceFileName,
    [string]$ClassName,
    [Array]$Methods
)

# Generate interface file
@"
namespace Bencher.Interfaces;

    public interface I$ClassName
    {
"@ > $InterfaceFileName

foreach ($method in $Methods) {
    "        Task<string> $method(string data);" >> $InterfaceFileName
}
    "}" >> $InterfaceFileName