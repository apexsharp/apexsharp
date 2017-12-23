namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_ContentHub_static_methods.htm#apex_ConnectAPI_ContentHub_static_methods
    /// </summary>
    public class ContentHub
    {
        // infrastructure
        public ContentHub(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHub));
            }
        }

        // API
        public static RepositoryFolderItem addRepositoryItem(string repositoryId, string repositoryFolderId, ContentHubItemInput file)
        {
            return Implementation.addRepositoryItem(repositoryId, repositoryFolderId, file);
        }

        public static RepositoryFolderItem addRepositoryItem(string communityId, string repositoryId, string repositoryFolderId, ContentHubItemInput file)
        {
            return Implementation.addRepositoryItem(communityId, repositoryId, repositoryFolderId, file);
        }

        public static RepositoryFolderItem addRepositoryItem(string repositoryId, string repositoryFolderId, ContentHubItemInput file, BinaryInput fileData)
        {
            return Implementation.addRepositoryItem(repositoryId, repositoryFolderId, file, fileData);
        }

        public static RepositoryFolderItem addRepositoryItem(string communityId, string repositoryId, string repositoryFolderId, ContentHubItemInput file, BinaryInput fileData)
        {
            return Implementation.addRepositoryItem(communityId, repositoryId, repositoryFolderId, file, fileData);
        }

        public static ContentHubAllowedItemTypeCollection getAllowedItemTypes(string repositoryId, string repositoryFolderId)
        {
            return Implementation.getAllowedItemTypes(repositoryId, repositoryFolderId);
        }

        public static ContentHubAllowedItemTypeCollection getAllowedItemTypes(string repositoryId, string repositoryFolderId, ConnectContentHubItemType filter)
        {
            return Implementation.getAllowedItemTypes(repositoryId, repositoryFolderId, filter);
        }

        public static ContentHubAllowedItemTypeCollection getAllowedItemTypes(string communityId, string repositoryId, string repositoryFolderId)
        {
            return Implementation.getAllowedItemTypes(communityId, repositoryId, repositoryFolderId);
        }

        public static ContentHubAllowedItemTypeCollection getAllowedItemTypes(string communityId, string repositoryId, string repositoryFolderId, ConnectContentHubItemType filter)
        {
            return Implementation.getAllowedItemTypes(communityId, repositoryId, repositoryFolderId, filter);
        }

        public static FilePreview getFilePreview(string repositoryId, string repositoryFileId, FilePreviewFormat formatType)
        {
            return Implementation.getFilePreview(repositoryId, repositoryFileId, formatType);
        }

        public static FilePreview getFilePreview(string repositoryId, string repositoryFileId, FilePreviewFormat formatType, int startPageNumber, int endPageNumber)
        {
            return Implementation.getFilePreview(repositoryId, repositoryFileId, formatType, startPageNumber, endPageNumber);
        }

        public static FilePreview getFilePreview(string communityId, string repositoryId, string repositoryFileId, FilePreviewFormat formatType)
        {
            return Implementation.getFilePreview(communityId, repositoryId, repositoryFileId, formatType);
        }

        public static FilePreview getFilePreview(string communityId, string repositoryId, string repositoryFileId, FilePreviewFormat formatType, int startPageNumber, int endPageNumber)
        {
            return Implementation.getFilePreview(communityId, repositoryId, repositoryFileId, formatType, startPageNumber, endPageNumber);
        }

        public static ContentHubItemTypeDetail getItemType(string repositoryId, string repositoryItemTypeId)
        {
            return Implementation.getItemType(repositoryId, repositoryItemTypeId);
        }

        public static ContentHubItemTypeDetail getItemType(string communityId, string repositoryId, string repositoryItemTypeId)
        {
            return Implementation.getItemType(communityId, repositoryId, repositoryItemTypeId);
        }

        public static FilePreviewCollection getPreviews(string repositoryId, string repositoryFileId)
        {
            return Implementation.getPreviews(repositoryId, repositoryFileId);
        }

        public static FilePreviewCollection getPreviews(string communityId, string repositoryId, string repositoryFileId)
        {
            return Implementation.getPreviews(communityId, repositoryId, repositoryFileId);
        }

        public static ContentHubRepositoryCollection getRepositories()
        {
            return Implementation.getRepositories();
        }

        public static ContentHubRepositoryCollection getRepositories(string communityId)
        {
            return Implementation.getRepositories(communityId);
        }

        public static ContentHubRepositoryCollection getRepositories(int pageParam, int pageSize)
        {
            return Implementation.getRepositories(pageParam, pageSize);
        }

        public static ContentHubRepositoryCollection getRepositories(string communityId, int pageParam, int pageSize)
        {
            return Implementation.getRepositories(communityId, pageParam, pageSize);
        }

        public static ContentHubRepository getRepository(string repositoryId)
        {
            return Implementation.getRepository(repositoryId);
        }

        public static ContentHubRepository getRepository(string communityId, string repositoryId)
        {
            return Implementation.getRepository(communityId, repositoryId);
        }

        public static RepositoryFileDetail getRepositoryFile(string repositoryId, string repositoryFileId)
        {
            return Implementation.getRepositoryFile(repositoryId, repositoryFileId);
        }

        public static RepositoryFileDetail getRepositoryFile(string repositoryId, string repositoryFileId, bool includeExternalFilePermissionsInfo)
        {
            return Implementation.getRepositoryFile(repositoryId, repositoryFileId, includeExternalFilePermissionsInfo);
        }

        public static RepositoryFileDetail getRepositoryFile(string communityId, string repositoryId, string repositoryFileId)
        {
            return Implementation.getRepositoryFile(communityId, repositoryId, repositoryFileId);
        }

        public static RepositoryFileDetail getRepositoryFile(string communityId, string repositoryId, string repositoryFileId, bool includeExternalFilePermissionsInfo)
        {
            return Implementation.getRepositoryFile(communityId, repositoryId, repositoryFileId, includeExternalFilePermissionsInfo);
        }

        public static RepositoryFolderDetail getRepositoryFolder(string repositoryId, string repositoryFolderId)
        {
            return Implementation.getRepositoryFolder(repositoryId, repositoryFolderId);
        }

        public static RepositoryFolderDetail getRepositoryFolder(string communityId, string repositoryId, string repositoryFolderId)
        {
            return Implementation.getRepositoryFolder(communityId, repositoryId, repositoryFolderId);
        }

        public static RepositoryFolderItemsCollection getRepositoryFolderItems(string repositoryId, string repositoryFolderId)
        {
            return Implementation.getRepositoryFolderItems(repositoryId, repositoryFolderId);
        }

        public static RepositoryFolderItemsCollection getRepositoryFolderItems(string communityId, string repositoryId, string repositoryFolderId)
        {
            return Implementation.getRepositoryFolderItems(communityId, repositoryId, repositoryFolderId);
        }

        public static RepositoryFolderItemsCollection getRepositoryFolderItems(string repositoryId, string repositoryFolderId, int pageParam, int pageSize)
        {
            return Implementation.getRepositoryFolderItems(repositoryId, repositoryFolderId, pageParam, pageSize);
        }

        public static RepositoryFolderItemsCollection getRepositoryFolderItems(string communityId, string repositoryId, string repositoryFolderId, int pageParam, int pageSize)
        {
            return Implementation.getRepositoryFolderItems(communityId, repositoryId, repositoryFolderId, pageParam, pageSize);
        }

        public static RepositoryFileDetail updateRepositoryFile(string repositoryId, string repositoryFileId, ContentHubItemInput file)
        {
            return Implementation.updateRepositoryFile(repositoryId, repositoryFileId, file);
        }

        public static RepositoryFileDetail updateRepositoryFile(string repositoryId, string repositoryFileId, ContentHubItemInput file, BinaryInput fileData)
        {
            return Implementation.updateRepositoryFile(repositoryId, repositoryFileId, file, fileData);
        }

        public static RepositoryFileDetail updateRepositoryFile(string communityId, string repositoryId, string repositoryFileId, ContentHubItemInput file)
        {
            return Implementation.updateRepositoryFile(communityId, repositoryId, repositoryFileId, file);
        }

        public static RepositoryFileDetail updateRepositoryFile(string communityId, string repositoryId, string repositoryFileId, ContentHubItemInput file, BinaryInput fileData)
        {
            return Implementation.updateRepositoryFile(communityId, repositoryId, repositoryFileId, file, fileData);
        }

        public static void setTestAddRepositoryItem(string repositoryId, string repositoryFolderId, ContentHubItemInput file, RepositoryFolderItem result)
        {
            Implementation.setTestAddRepositoryItem(repositoryId, repositoryFolderId, file, result);
        }

        public static void setTestAddRepositoryItem(string communityId, string repositoryId, string repositoryFolderId, ContentHubItemInput file, RepositoryFolderItem result)
        {
            Implementation.setTestAddRepositoryItem(communityId, repositoryId, repositoryFolderId, file, result);
        }

        public static void setTestAddRepositoryItem(string repositoryId, string repositoryFolderId, ContentHubItemInput file, BinaryInput fileData, RepositoryFolderItem result)
        {
            Implementation.setTestAddRepositoryItem(repositoryId, repositoryFolderId, file, fileData, result);
        }

        public static void setTestAddRepositoryItem(string communityId, string repositoryId, string repositoryFolderId, ContentHubItemInput file, BinaryInput fileData, RepositoryFolderItem result)
        {
            Implementation.setTestAddRepositoryItem(communityId, repositoryId, repositoryFolderId, file, fileData, result);
        }

        public static void setTestGetAllowedItemTypes(string repositoryId, string repositoryFolderId, ContentHubAllowedItemTypeCollection result)
        {
            Implementation.setTestGetAllowedItemTypes(repositoryId, repositoryFolderId, result);
        }

        public static void setTestGetAllowedItemTypes(string repositoryId, string repositoryFolderId, ContentHubItemType filter, ContentHubAllowedItemTypeCollection result)
        {
            Implementation.setTestGetAllowedItemTypes(repositoryId, repositoryFolderId, filter, result);
        }

        public static void setTestGetAllowedItemTypes(string communityId, string repositoryId, string repositoryFolderId, ContentHubAllowedItemTypeCollection result)
        {
            Implementation.setTestGetAllowedItemTypes(communityId, repositoryId, repositoryFolderId, result);
        }

        public static void setTestGetAllowedItemTypes(string communityId, string repositoryId, string repositoryFolderId, ContentHubItemType filter, ContentHubAllowedItemTypeCollection result)
        {
            Implementation.setTestGetAllowedItemTypes(communityId, repositoryId, repositoryFolderId, filter, result);
        }

        public static void setTestGetFilePreview(string repositoryId, string repositoryFileId, FilePreviewFormat formatType, FilePreview result)
        {
            Implementation.setTestGetFilePreview(repositoryId, repositoryFileId, formatType, result);
        }

        public static void setTestGetFilePreview(string repositoryId, string repositoryFileId, FilePreviewFormat formatType, int startPageNumber, int endPageNumber, FilePreview result)
        {
            Implementation.setTestGetFilePreview(repositoryId, repositoryFileId, formatType, startPageNumber, endPageNumber, result);
        }

        public static void setTestGetFilePreview(string communityId, string repositoryId, string repositoryFileId, FilePreviewFormat formatType, FilePreview result)
        {
            Implementation.setTestGetFilePreview(communityId, repositoryId, repositoryFileId, formatType, result);
        }

        public static void setTestGetFilePreview(string communityId, string repositoryId, string repositoryFileId, FilePreviewFormat formatType, int startPageNumber, int endPageNumber, FilePreview result)
        {
            Implementation.setTestGetFilePreview(communityId, repositoryId, repositoryFileId, formatType, startPageNumber, endPageNumber, result);
        }

        public static void setTestGetItemType(string repositoryId, string repositoryItemTypeId, ContentHubItemTypeDetail result)
        {
            Implementation.setTestGetItemType(repositoryId, repositoryItemTypeId, result);
        }

        public static void setTestGetItemType(string communityId, string repositoryId, string repositoryItemTypeId, ContentHubItemTypeDetail result)
        {
            Implementation.setTestGetItemType(communityId, repositoryId, repositoryItemTypeId, result);
        }

        public static void setTestGetPreviews(string repositoryId, string repositoryFileId, FilePreviewCollection result)
        {
            Implementation.setTestGetPreviews(repositoryId, repositoryFileId, result);
        }

        public static void setTestGetPreviews(string communityId, string repositoryId, string repositoryFileId, FilePreviewCollection result)
        {
            Implementation.setTestGetPreviews(communityId, repositoryId, repositoryFileId, result);
        }

        public static void setTestGetRepositories(ContentHubRepositoryCollection result)
        {
            Implementation.setTestGetRepositories(result);
        }

        public static void setTestGetRepositories(string communityId, ContentHubRepositoryCollection result)
        {
            Implementation.setTestGetRepositories(communityId, result);
        }

        public static void setTestGetRepositories(int pageParam, int pageSize, ContentHubRepositoryCollection result)
        {
            Implementation.setTestGetRepositories(pageParam, pageSize, result);
        }

        public static void setTestGetRepositories(string communityId, int pageParam, int pageSize, ContentHubRepositoryCollection result)
        {
            Implementation.setTestGetRepositories(communityId, pageParam, pageSize, result);
        }

        public static void setTestGetRepository(string repositoryId, ContentHubRepository result)
        {
            Implementation.setTestGetRepository(repositoryId, result);
        }

        public static void setTestGetRepository(string communityId, string repositoryId, ContentHubRepository result)
        {
            Implementation.setTestGetRepository(communityId, repositoryId, result);
        }

        public static void setTestGetRepositoryFile(string repositoryId, string repositoryFileId, RepositoryFileDetail result)
        {
            Implementation.setTestGetRepositoryFile(repositoryId, repositoryFileId, result);
        }

        public static void setTestGetRepositoryFile(string repositoryId, string repositoryFileId, bool includeExternalFilePermissionsInfo, RepositoryFileDetail result)
        {
            Implementation.setTestGetRepositoryFile(repositoryId, repositoryFileId, includeExternalFilePermissionsInfo, result);
        }

        public static void setTestGetRepositoryFile(string communityId, string repositoryId, string repositoryFileId, RepositoryFileDetail result)
        {
            Implementation.setTestGetRepositoryFile(communityId, repositoryId, repositoryFileId, result);
        }

        public static void setTestGetRepositoryFile(string communityId, string repositoryId, string repositoryFileId, bool includeExternalFilePermissionsInfo, RepositoryFileDetail result)
        {
            Implementation.setTestGetRepositoryFile(communityId, repositoryId, repositoryFileId, includeExternalFilePermissionsInfo, result);
        }

        public static void setTestGetRepositoryFolder(string repositoryId, string repositoryFolderId, RepositoryFolderDetail result)
        {
            Implementation.setTestGetRepositoryFolder(repositoryId, repositoryFolderId, result);
        }

        public static void setTestGetRepositoryFolder(string communityId, string repositoryId, string repositoryFolderId, RepositoryFolderDetail result)
        {
            Implementation.setTestGetRepositoryFolder(communityId, repositoryId, repositoryFolderId, result);
        }

        public static void setTestGetRepositoryFolderItems(string repositoryId, string repositoryFolderId, RepositoryFolderItemsCollection result)
        {
            Implementation.setTestGetRepositoryFolderItems(repositoryId, repositoryFolderId, result);
        }

        public static void setTestGetRepositoryFolderItems(string communityId, string repositoryId, string repositoryFolderId, RepositoryFolderItemsCollection result)
        {
            Implementation.setTestGetRepositoryFolderItems(communityId, repositoryId, repositoryFolderId, result);
        }

        public static void setTestGetRepositoryFolderItems(string repositoryId, string repositoryFolderId, int pageParam, int pageSize, RepositoryFolderItemsCollection result)
        {
            Implementation.setTestGetRepositoryFolderItems(repositoryId, repositoryFolderId, pageParam, pageSize, result);
        }

        public static void setTestGetRepositoryFolderItems(string communityId, string repositoryId, string repositoryFolderId, int pageParam, int pageSize, RepositoryFolderItemsCollection result)
        {
            Implementation.setTestGetRepositoryFolderItems(communityId, repositoryId, repositoryFolderId, pageParam, pageSize, result);
        }

        public static void setTestUpdateRepositoryFile(string communityId, string repositoryId, string repositoryFileId, ContentHubItemInput file, BinaryInput fileData, RepositoryFileDetail result)
        {
            Implementation.setTestUpdateRepositoryFile(communityId, repositoryId, repositoryFileId, file, fileData, result);
        }

        public static void setTestUpdateRepositoryFile(string repositoryId, string repositoryFileId, ContentHubItemInput file, RepositoryFileDetail result)
        {
            Implementation.setTestUpdateRepositoryFile(repositoryId, repositoryFileId, file, result);
        }

        public static void setTestUpdateRepositoryFile(string repositoryId, string repositoryFileId, ContentHubItemInput file, BinaryInput fileData, RepositoryFileDetail result)
        {
            Implementation.setTestUpdateRepositoryFile(repositoryId, repositoryFileId, file, fileData, result);
        }

        public static void setTestUpdateRepositoryFile(string communityId, string repositoryId, string repositoryFileId, ContentHubItemInput file, RepositoryFileDetail result)
        {
            Implementation.setTestUpdateRepositoryFile(communityId, repositoryId, repositoryFileId, file, result);
        }
    }
}
