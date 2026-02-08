# $scriptRoot = Split-Path -Parent $MyInvocation.MyCommand.Path
# $exe = Join-Path $scriptRoot "bin\Debug\net10.0\Thread_2.exe"

$exe = "D:\Practice\Test\Thread_2\bin\Debug\net10.0\Thread_2.exe"

if (-not (Test-Path $exe)) {
    throw "EXE not found: $exe"
}

1..2 | ForEach-Object {
    Start-Process $exe
}
