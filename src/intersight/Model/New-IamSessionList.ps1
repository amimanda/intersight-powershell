function New-IamSessionList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Count},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.IamSession[]]]
        ${Results}
    )

    Process {
        'Creating object: intersight.Model.IamSessionList' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.IamSessionList -ArgumentList @(
            ${Count},
            ${Results}
        )
    }
}
