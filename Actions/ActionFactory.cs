using System;
using System.Collections.Generic;
using System.Linq;
using Optional;

namespace Slack.Integration.Actions
{
    public class ActionFactory
    {
        private List<IRequestAction> actions;

        public ActionFactory(IServiceProvider services)
        {
            this.actions = new List<IRequestAction>
            {
                (IRequestAction)services.GetService(typeof(PullRequestAction)),
                (IRequestAction)services.GetService(typeof(ReviewRequestAction))
            };
        }

        public IEnumerable<IRequestAction> Resolve(string requestAction, string action)
        {
            return actions.Where(x => x.RequestType == requestAction && x.RequestAction == action);
        }
    }
}