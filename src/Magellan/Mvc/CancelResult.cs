﻿using Magellan.Diagnostics;

namespace Magellan.Mvc
{
    /// <summary>
    /// An action result that does nothing.
    /// </summary>
    public class CancelResult : ActionResult
    {
        /// <summary>
        /// Executes the action result.
        /// </summary>
        /// <param name="controllerContext"></param>
        protected override void ExecuteInternal(ControllerContext controllerContext)
        {
            TraceSources.MagellanSource.TraceInformation("CancelResult is rendering for request '{0}'.", controllerContext.Request);
        }
    }
}
