namespace Identity4121.Application.EventLogs
{
    public class PublishEventService
    {
        private readonly ILogger<PublishEventService> _logger;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IRepository<EventLog, long> _eventLogRepository;
        private readonly IMessageSender<FileUploadedEvent> _fileUploadedEventSender;
        private readonly IMessageSender<FileDeletedEvent> _fileDeletedEventSender;

        public PublishEventService(ILogger<PublishEventService> logger,
            IDateTimeProvider dateTimeProvider,
            IRepository<EventLog, long> eventLogRepository,
            IMessageSender<FileUploadedEvent> fileUploadedEventSender,
            IMessageSender<FileDeletedEvent> fileDeletedEventSender)
        {
            _logger = logger;
            _dateTimeProvider = dateTimeProvider;
            _eventLogRepository = eventLogRepository;
            _fileUploadedEventSender = fileUploadedEventSender;
            _fileDeletedEventSender = fileDeletedEventSender;
        }

        public async Task<int> PublishEvents()
        {
            var events = _eventLogRepository.GetAll()
                .Where(x => !x.Published)
                .OrderBy(x => x.CreatedDateTime)
                .Take(50)
                .ToList();

            foreach (var eventLog in events)
            {
                if (eventLog.EventType == "FILEENTRY_CREATED")
                {
                    await _fileUploadedEventSender.SendAsync(new FileUploadedEvent { FileEntry = JsonSerializer.Deserialize<FileEntry>(eventLog.Message) });
                }
                else if (eventLog.EventType == "FILEENTRY_DELETED")
                {
                    await _fileDeletedEventSender.SendAsync(new FileDeletedEvent { FileEntry = JsonSerializer.Deserialize<FileEntry>(eventLog.Message) });
                }
                else
                {
                    // TODO: Take Note
                }

                eventLog.Published = true;
                eventLog.UpdatedDateTime = _dateTimeProvider.OffsetNow;
                await _eventLogRepository.UnitOfWork.SaveChangesAsync();
            }

            return events.Count;
        }
    }
}
