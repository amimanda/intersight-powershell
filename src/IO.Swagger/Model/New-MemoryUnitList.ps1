function New-MemoryUnitList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Count},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.MemoryUnit[]]]
        ${Results}
    )

    Process {
        'Creating object: intersight.Model.MemoryUnitList' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.MemoryUnitList -ArgumentList @(
            ${Count},
            ${Results}
        )
    }
}
