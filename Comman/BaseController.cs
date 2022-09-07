namespace ECommerce.Application
{
    using AutoMapper;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TViewModel> : ControllerBase where 
        TEntity : BaseEntity
        where TViewModel : BaseViewModel
    {
        protected readonly IBaseUnitOfWork<TEntity> _baseUnitOfWork;
        protected readonly IMapper _mapper;
        private readonly IValidator<TViewModel> _validator;

        public BaseController(IBaseUnitOfWork<TEntity> baseUnitOfWork, IMapper mapper, IValidator<TViewModel> validator)
        {
            _baseUnitOfWork = baseUnitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        // GET: api/<ProductsController>
        [HttpGet]

        public virtual async Task<IActionResult> GetAll()
        {
            var entities = await _baseUnitOfWork.ReadAsync();
            return Ok(entities);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(Guid id)
        {
            TEntity  entity = await _baseUnitOfWork.ReadByIdAsync(id);
          
            return Ok(entity);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public virtual async  Task<IActionResult> Post([FromBody] TViewModel viewModel)
        {
            var  validationResult = await _validator.ValidateAsync(viewModel);
            if (!validationResult.IsValid)
                return BadRequest(new { errors = validationResult.Errors });

            var entity = _mapper.Map<TEntity>(viewModel);
            entity = await _baseUnitOfWork.CreateAsync(entity);
            return Ok(_mapper.Map<TViewModel>(entity));
        }

        // PUT api/<ProductsController>/5
        [HttpPut]
        public virtual async Task<IActionResult> Put([FromBody] TViewModel viewModel)
        {
            var validationResult = await _validator.ValidateAsync(viewModel);
            if (!validationResult.IsValid)
                return BadRequest(new { errors = validationResult.Errors });

            var entity = _mapper.Map<TEntity>(viewModel);
            entity = await _baseUnitOfWork.UpdateAsync(entity);
            return Ok(_mapper.Map<TViewModel>(entity));
        }
        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public virtual async Task Delete(Guid id)
        {
            await _baseUnitOfWork.DeleteAsync(id);
        }
    }
}
    

