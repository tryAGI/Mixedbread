#nullable enable

namespace Mixedbread
{
    public partial interface IStoresClient
    {

        /// <summary>
        /// Delete a specific rule from rules array<br/>
        /// Delete a specific rule from within a search rule's rules array.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store<br/>
        ///     rule_id: The ID of the search rule containing the rule to delete<br/>
        ///     rule_delete: The specific rule to delete from the rules array<br/>
        /// Returns:<br/>
        ///     SearchRuleSpecificDeleted: Details about the deletion operation
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="ruleId">
        /// The ID of the search rule
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mixedbread.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted> DeleteSpecificSearchRuleAsync(
            global::Mixedbread.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Guid ruleId,

            global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a specific rule from rules array<br/>
        /// Delete a specific rule from within a search rule's rules array.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store<br/>
        ///     rule_id: The ID of the search rule containing the rule to delete<br/>
        ///     rule_delete: The specific rule to delete from the rules array<br/>
        /// Returns:<br/>
        ///     SearchRuleSpecificDeleted: Details about the deletion operation
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="ruleId">
        /// The ID of the search rule
        /// </param>
        /// <param name="rule">
        /// The specific rule to delete from the rules array
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleted> DeleteSpecificSearchRuleAsync(
            global::Mixedbread.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Guid ruleId,
            global::Mixedbread.Rule2 rule,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}