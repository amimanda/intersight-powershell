function New-IamLdapPolicyList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Count},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.IamLdapPolicy[]]]
        ${Results}
    )

    Process {
        'Creating object: intersight.Model.IamLdapPolicyList' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.IamLdapPolicyList -ArgumentList @(
            ${Count},
            ${Results}
        )
    }
}
