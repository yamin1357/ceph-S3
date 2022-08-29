using System;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;



namespace Ceph_S3
{
    class Program
    {
        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.MESouth1;
        static void Main(string[] args)
        {
            string accessKey = "Q1QRRFJCPDABB5YQ3C42";
            string secretKey = "Yj3l0e9qDMaoXSDX5HWMwer1nezHQ4oqoQVMnikM";

            AmazonS3Config config = new AmazonS3Config();
            config.ServiceURL = "http://185.78.23.136:22080";
           
            AmazonS3Client client = new AmazonS3Client(accessKey,secretKey,config);

            // List Bucket
            
            ListBucketsResponse response = client.ListBucketsAsync().GetAwaiter().GetResult();
            foreach (S3Bucket b in response.Buckets)
            {
                Console.WriteLine("{0}\t{1}", b.BucketName, b.CreationDate);
            }
            


            // Create Bucket
            /*
            PutBucketRequest request = new PutBucketRequest();
            request.BucketName = "mynewbucket";
            client.PutBucketAsync(request);
            */

            // Delete Bucket
            /*
            DeleteBucketRequest request = new DeleteBucketRequest();
            request.BucketName = "testbucket";
            client.DeleteBucketAsync(request).GetAwaiter().GetResult();
            */
        }
    }
}
