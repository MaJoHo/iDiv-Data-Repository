﻿namespace BExIS.Security.Services.Utilities
{
    public class MessageHelper
    {
        public static string GetCreateDatasetHeader()
        {
            return $"Dataset was created";
        }

        public static string GetCreateDatasetMessage(long datasetid, string title, string userName)
        {
            string message = $"Dataset <b>\"{title}\"</b> with id <b>({datasetid})</b> was created";

            if (!string.IsNullOrEmpty(userName))

                return message += $" by <b>{userName}</b>";

            return message + ".";
        }

        public static string GetDeleteDatasetHeader()
        {
            return $"Dataset was deleted";
        }

        public static string GetDeleteDatasetMessage(long datasetid, string userName)
        {
            string message = $"Dataset with id <b>({datasetid})</b> was deleted";

            if (!string.IsNullOrEmpty(userName))

                return message += $" by <b>{userName}</b>";

            return message + ".";
        }

        public static string GetTryToDeleteDatasetHeader()
        {
            return $"Someone tried to delete a dataset";
        }

        public static string GetTryToDeleteDatasetMessage(long datasetid, string userName)
        {
            string message = $"An unsuccessful attempt was made to delete a Dataset with id <b>({datasetid})</b>";

            if (!string.IsNullOrEmpty(userName))

                return message += $" by <b>{userName}</b>";

            return message + ".";
        }

        public static string GetPurgeDatasetHeader()
        {
            return $"Dataset was purged";
        }

        public static string GetPurgeDatasetMessage(long datasetid, string userName)
        {
            string message = $"Dataset with id <b>({datasetid})</b> was purged";

            if (!string.IsNullOrEmpty(userName))

                return message += $" by <b>{userName}</b>";

            return message + ".";
        }

        public static string GetTryToPurgeDatasetHeader()
        {
            return $"Someone tried to purge a dataset";
        }

        public static string GetTryToPurgeDatasetMessage(long datasetid, string userName)
        {
            string message = $"An unsuccessful attempt was made to purge a Dataset with id <b>({datasetid})</b>";

            if (!string.IsNullOrEmpty(userName))

                return message += $" by <b>{userName}</b>";

            return message + ".";
        }

        public static string GetDownloadDatasetHeader()
        {
            return $"Dataset was downloaded";
        }

        public static string GetDownloadDatasetMessage(long datasetid, string title, string userName)
        {
            string message = $"Dataset <b>\"{title}\"</b> with id <b>({datasetid})</b> was downloaded";

            if (!string.IsNullOrEmpty(userName))

                return message += $" by <b>{userName}</b>";

            return message + ".";
        }

        public static string GetErrorHeader()
        {
            return $"Error in System";
        }

        public static string GetRegisterUserHeader()
        {
            return $"User has registered";
        }

        public static string GetRegisterUserMessage(long userId, string userName, string email)
        {
            return $"User <b>\"{userName}\"</b>(Id: {userId}) with email <b>({email})</b> has registered.";
        }

        public static string GetSendRequestHeader(long datasetid)
        {
            return $"Request to dataset with id  {datasetid}";
        }

        public static string GetSendRequestMessage(long datasetid, string title, string requester)
        {
            return $"User \"{requester}\" sent a request for Dataset <b>\"{title}\"</b> with id <b>({datasetid})</b>";
        }

        public static string GetTryToRegisterUserHeader()
        {
            return $"User tries to register";
        }

        public static string GetTryToRegisterUserMessage(long userId, string userName, string email)
        {
            return $"User <b>\"{userName}\"</b>(Id: {userId}) with email <b>({email})</b> tries to register.";
        }

        public static string GetUpdateDatasetHeader()
        {
            return $"Dataset was updated";
        }

        public static string GetUpdateDatasetMessage(long datasetid, string title, string userName)
        {
            string message = $"Dataset <b>\"{title}\"</b> with id <b>({datasetid})</b> was updated";

            if (!string.IsNullOrEmpty(userName))

                return message += $" by <b>{userName}</b>";

            return message + ".";
        }

        public static string GetUpdateProfileHeader()
        {
            return $"User has modified profile";
        }

        public static string GetUpdaterProfileMessage(long userId, string userName)
        {
            return $"User <b>\"{userName}\"</b>(Id: {userId}) has updated his/her profile.";
        }
    }
}