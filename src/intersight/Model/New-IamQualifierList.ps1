function New-IamQualifierList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Count},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.IamQualifier[]]]
        ${Results}
    )

    Process {
        'Creating object: intersight.Model.IamQualifierList' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.IamQualifierList -ArgumentList @(
            ${Count},
            ${Results}
        )
    }
}
