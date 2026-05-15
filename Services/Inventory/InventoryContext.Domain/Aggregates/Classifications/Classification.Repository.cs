using System;
using System.Collections.Generic;
using System.Text;
using CommonContext.Abstracts;
using CommonContext.Abstracts.Repositories;
using InventoryContext.Aggregates.Classifications;

namespace InventoryContext.Domain.Aggregates.Classifications;

public interface IClassificationRepository : IRepository<Classification, ClassificationId>
{

}
