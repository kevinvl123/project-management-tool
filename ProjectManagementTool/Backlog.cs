using System;
using System.Collections.Generic;

namespace ProjectManagementTool
{
    class Backlog
    {
        private readonly EnhancedList<Story> _backlogStories;
        private readonly List<Story> _todoStories;
        private readonly List<Story> _doingStories;
        private readonly List<Story> _doneStories;

        public Backlog()
        {
            _backlogStories = new EnhancedList<Story>();
            _todoStories = new List<Story>();
            _doingStories = new List<Story>();
            _doneStories = new List<Story>();
        }

        public List<Story> BacklogStories
        {
            get { return _backlogStories; }
        }

        public List<Story> TodoStories
        {
            get { return _todoStories; }
        }

        public List<Story> DoingStories
        {
            get { return _doingStories; }
        }

        public List<Story> DoneStories
        {
            get { return _doneStories; }
        }

        public void AddStory(Story story)
        {
            _backlogStories.Add(story);
        }

        public Story GetStoryByGuid(String guid)
        {
            foreach (Story s in _backlogStories)
            {
                if (s.Id.Equals(guid))
                    return s;
            } 
            foreach (Story s in _todoStories)
            {
                if (s.Id.Equals(guid))
                    return s;
            } 
            foreach (Story s in _doingStories)
            {
                if (s.Id.Equals(guid))
                    return s;
            } 
            foreach (Story s in _doneStories)
            {
                if (s.Id.Equals(guid))
                    return s;
            }
            return null;
        }

        public void MoveStory(String guid, String destination)
        {
            for (int i = _backlogStories.Count - 1; i >= 0; i--)
            {
                if (_backlogStories[i].Id.Equals(guid))
                {
                    _backlogStories[i].Status = destination;
                    switch (destination)
                    {
                        case "TODO":
                            _todoStories.Add(_backlogStories[i]);
                            _backlogStories.RemoveAt(i);
                            break;
                        case "DOING":
                            _doingStories.Add(_backlogStories[i]);
                            _backlogStories.RemoveAt(i);
                            break;
                        case "DONE":
                            _doingStories.Add(_backlogStories[i]);
                            _backlogStories.RemoveAt(i);
                            break;
                    }
                }
            }
            for (int i = _todoStories.Count - 1; i >= 0; i--)
            {
                if (_todoStories[i].Id.Equals(guid))
                {
                    _todoStories[i].Status = destination;
                    switch (destination)
                    {
                        case "BACKLOG":
                            _backlogStories.Add(_todoStories[i]);
                            _todoStories.RemoveAt(i);
                            break;
                        case "DOING":
                            _doingStories.Add(_todoStories[i]);
                            _todoStories.RemoveAt(i);
                            break;
                        case "DONE":
                            _doingStories.Add(_todoStories[i]);
                            _todoStories.RemoveAt(i);
                            break;
                    }
                }
            }
            for (int i = _doingStories.Count - 1; i >= 0; i--)
            {
                if (_doingStories[i].Id.Equals(guid))
                {
                    _doingStories[i].Status = destination;
                    switch (destination)
                    {
                        case "BACKLOG":
                            _backlogStories.Add(_doingStories[i]);
                            _doingStories.RemoveAt(i);
                            break;
                        case "TODO":
                            _todoStories.Add(_doingStories[i]);
                            _doingStories.RemoveAt(i);
                            break;
                        case "DONE":
                            _doneStories.Add(_doingStories[i]);
                            _doingStories.RemoveAt(i);
                            break;
                    }
                }
            }
            for (int i = _doneStories.Count - 1; i >= 0; i--)
            {
                if (_doneStories[i].Id.Equals(guid))
                {
                    _doneStories[i].Status = destination;
                    switch (destination)
                    {
                        case "BACKLOG":
                            _backlogStories.Add(_doneStories[i]);
                            _doneStories.RemoveAt(i);
                            break;
                        case "TODO":
                            _todoStories.Add(_doneStories[i]);
                            _doneStories.RemoveAt(i);
                            break;
                        case "DOING":
                            _doingStories.Add(_doneStories[i]);
                            _doneStories.RemoveAt(i);
                            break;
                    }
                }
            }
        }
    }
}
