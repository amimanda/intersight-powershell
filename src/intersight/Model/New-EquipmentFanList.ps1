function New-EquipmentFanList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Count},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.EquipmentFan[]]]
        ${Results}
    )

    Process {
        'Creating object: intersight.Model.EquipmentFanList' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.EquipmentFanList -ArgumentList @(
            ${Count},
            ${Results}
        )
    }
}
