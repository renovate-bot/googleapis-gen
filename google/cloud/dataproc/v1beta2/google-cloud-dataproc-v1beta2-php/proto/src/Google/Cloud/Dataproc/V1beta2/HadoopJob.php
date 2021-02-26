<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dataproc/v1beta2/jobs.proto

namespace Google\Cloud\Dataproc\V1beta2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A Dataproc job for running
 * [Apache Hadoop
 * MapReduce](https://hadoop.apache.org/docs/current/hadoop-mapreduce-client/hadoop-mapreduce-client-core/MapReduceTutorial.html)
 * jobs on [Apache Hadoop
 * YARN](https://hadoop.apache.org/docs/r2.7.1/hadoop-yarn/hadoop-yarn-site/YARN.html).
 *
 * Generated from protobuf message <code>google.cloud.dataproc.v1beta2.HadoopJob</code>
 */
class HadoopJob extends \Google\Protobuf\Internal\Message
{
    /**
     * Optional. The arguments to pass to the driver. Do not
     * include arguments, such as `-libjars` or `-Dfoo=bar`, that can be set as
     * job properties, since a collision may occur that causes an incorrect job
     * submission.
     *
     * Generated from protobuf field <code>repeated string args = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    private $args;
    /**
     * Optional. Jar file URIs to add to the CLASSPATHs of the
     * Hadoop driver and tasks.
     *
     * Generated from protobuf field <code>repeated string jar_file_uris = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    private $jar_file_uris;
    /**
     * Optional. HCFS (Hadoop Compatible Filesystem) URIs of files to be copied
     * to the working directory of Hadoop drivers and distributed tasks. Useful
     * for naively parallel tasks.
     *
     * Generated from protobuf field <code>repeated string file_uris = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    private $file_uris;
    /**
     * Optional. HCFS URIs of archives to be extracted in the working directory of
     * Hadoop drivers and tasks. Supported file types:
     * .jar, .tar, .tar.gz, .tgz, or .zip.
     *
     * Generated from protobuf field <code>repeated string archive_uris = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    private $archive_uris;
    /**
     * Optional. A mapping of property names to values, used to configure Hadoop.
     * Properties that conflict with values set by the Dataproc API may be
     * overwritten. Can include properties set in /etc/hadoop/conf/&#42;-site and
     * classes in user code.
     *
     * Generated from protobuf field <code>map<string, string> properties = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    private $properties;
    /**
     * Optional. The runtime log config for job execution.
     *
     * Generated from protobuf field <code>.google.cloud.dataproc.v1beta2.LoggingConfig logging_config = 8 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $logging_config = null;
    protected $driver;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $main_jar_file_uri
     *           The HCFS URI of the jar file containing the main class.
     *           Examples:
     *               'gs://foo-bucket/analytics-binaries/extract-useful-metrics-mr.jar'
     *               'hdfs:/tmp/test-samples/custom-wordcount.jar'
     *               'file:///home/usr/lib/hadoop-mapreduce/hadoop-mapreduce-examples.jar'
     *     @type string $main_class
     *           The name of the driver's main class. The jar file containing the class
     *           must be in the default CLASSPATH or specified in `jar_file_uris`.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $args
     *           Optional. The arguments to pass to the driver. Do not
     *           include arguments, such as `-libjars` or `-Dfoo=bar`, that can be set as
     *           job properties, since a collision may occur that causes an incorrect job
     *           submission.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $jar_file_uris
     *           Optional. Jar file URIs to add to the CLASSPATHs of the
     *           Hadoop driver and tasks.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $file_uris
     *           Optional. HCFS (Hadoop Compatible Filesystem) URIs of files to be copied
     *           to the working directory of Hadoop drivers and distributed tasks. Useful
     *           for naively parallel tasks.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $archive_uris
     *           Optional. HCFS URIs of archives to be extracted in the working directory of
     *           Hadoop drivers and tasks. Supported file types:
     *           .jar, .tar, .tar.gz, .tgz, or .zip.
     *     @type array|\Google\Protobuf\Internal\MapField $properties
     *           Optional. A mapping of property names to values, used to configure Hadoop.
     *           Properties that conflict with values set by the Dataproc API may be
     *           overwritten. Can include properties set in /etc/hadoop/conf/&#42;-site and
     *           classes in user code.
     *     @type \Google\Cloud\Dataproc\V1beta2\LoggingConfig $logging_config
     *           Optional. The runtime log config for job execution.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dataproc\V1Beta2\Jobs::initOnce();
        parent::__construct($data);
    }

    /**
     * The HCFS URI of the jar file containing the main class.
     * Examples:
     *     'gs://foo-bucket/analytics-binaries/extract-useful-metrics-mr.jar'
     *     'hdfs:/tmp/test-samples/custom-wordcount.jar'
     *     'file:///home/usr/lib/hadoop-mapreduce/hadoop-mapreduce-examples.jar'
     *
     * Generated from protobuf field <code>string main_jar_file_uri = 1;</code>
     * @return string
     */
    public function getMainJarFileUri()
    {
        return $this->readOneof(1);
    }

    public function hasMainJarFileUri()
    {
        return $this->hasOneof(1);
    }

    /**
     * The HCFS URI of the jar file containing the main class.
     * Examples:
     *     'gs://foo-bucket/analytics-binaries/extract-useful-metrics-mr.jar'
     *     'hdfs:/tmp/test-samples/custom-wordcount.jar'
     *     'file:///home/usr/lib/hadoop-mapreduce/hadoop-mapreduce-examples.jar'
     *
     * Generated from protobuf field <code>string main_jar_file_uri = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setMainJarFileUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * The name of the driver's main class. The jar file containing the class
     * must be in the default CLASSPATH or specified in `jar_file_uris`.
     *
     * Generated from protobuf field <code>string main_class = 2;</code>
     * @return string
     */
    public function getMainClass()
    {
        return $this->readOneof(2);
    }

    public function hasMainClass()
    {
        return $this->hasOneof(2);
    }

    /**
     * The name of the driver's main class. The jar file containing the class
     * must be in the default CLASSPATH or specified in `jar_file_uris`.
     *
     * Generated from protobuf field <code>string main_class = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setMainClass($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * Optional. The arguments to pass to the driver. Do not
     * include arguments, such as `-libjars` or `-Dfoo=bar`, that can be set as
     * job properties, since a collision may occur that causes an incorrect job
     * submission.
     *
     * Generated from protobuf field <code>repeated string args = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getArgs()
    {
        return $this->args;
    }

    /**
     * Optional. The arguments to pass to the driver. Do not
     * include arguments, such as `-libjars` or `-Dfoo=bar`, that can be set as
     * job properties, since a collision may occur that causes an incorrect job
     * submission.
     *
     * Generated from protobuf field <code>repeated string args = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setArgs($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->args = $arr;

        return $this;
    }

    /**
     * Optional. Jar file URIs to add to the CLASSPATHs of the
     * Hadoop driver and tasks.
     *
     * Generated from protobuf field <code>repeated string jar_file_uris = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getJarFileUris()
    {
        return $this->jar_file_uris;
    }

    /**
     * Optional. Jar file URIs to add to the CLASSPATHs of the
     * Hadoop driver and tasks.
     *
     * Generated from protobuf field <code>repeated string jar_file_uris = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setJarFileUris($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->jar_file_uris = $arr;

        return $this;
    }

    /**
     * Optional. HCFS (Hadoop Compatible Filesystem) URIs of files to be copied
     * to the working directory of Hadoop drivers and distributed tasks. Useful
     * for naively parallel tasks.
     *
     * Generated from protobuf field <code>repeated string file_uris = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getFileUris()
    {
        return $this->file_uris;
    }

    /**
     * Optional. HCFS (Hadoop Compatible Filesystem) URIs of files to be copied
     * to the working directory of Hadoop drivers and distributed tasks. Useful
     * for naively parallel tasks.
     *
     * Generated from protobuf field <code>repeated string file_uris = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setFileUris($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->file_uris = $arr;

        return $this;
    }

    /**
     * Optional. HCFS URIs of archives to be extracted in the working directory of
     * Hadoop drivers and tasks. Supported file types:
     * .jar, .tar, .tar.gz, .tgz, or .zip.
     *
     * Generated from protobuf field <code>repeated string archive_uris = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getArchiveUris()
    {
        return $this->archive_uris;
    }

    /**
     * Optional. HCFS URIs of archives to be extracted in the working directory of
     * Hadoop drivers and tasks. Supported file types:
     * .jar, .tar, .tar.gz, .tgz, or .zip.
     *
     * Generated from protobuf field <code>repeated string archive_uris = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setArchiveUris($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->archive_uris = $arr;

        return $this;
    }

    /**
     * Optional. A mapping of property names to values, used to configure Hadoop.
     * Properties that conflict with values set by the Dataproc API may be
     * overwritten. Can include properties set in /etc/hadoop/conf/&#42;-site and
     * classes in user code.
     *
     * Generated from protobuf field <code>map<string, string> properties = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getProperties()
    {
        return $this->properties;
    }

    /**
     * Optional. A mapping of property names to values, used to configure Hadoop.
     * Properties that conflict with values set by the Dataproc API may be
     * overwritten. Can include properties set in /etc/hadoop/conf/&#42;-site and
     * classes in user code.
     *
     * Generated from protobuf field <code>map<string, string> properties = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setProperties($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::STRING);
        $this->properties = $arr;

        return $this;
    }

    /**
     * Optional. The runtime log config for job execution.
     *
     * Generated from protobuf field <code>.google.cloud.dataproc.v1beta2.LoggingConfig logging_config = 8 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Cloud\Dataproc\V1beta2\LoggingConfig|null
     */
    public function getLoggingConfig()
    {
        return isset($this->logging_config) ? $this->logging_config : null;
    }

    public function hasLoggingConfig()
    {
        return isset($this->logging_config);
    }

    public function clearLoggingConfig()
    {
        unset($this->logging_config);
    }

    /**
     * Optional. The runtime log config for job execution.
     *
     * Generated from protobuf field <code>.google.cloud.dataproc.v1beta2.LoggingConfig logging_config = 8 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Cloud\Dataproc\V1beta2\LoggingConfig $var
     * @return $this
     */
    public function setLoggingConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dataproc\V1beta2\LoggingConfig::class);
        $this->logging_config = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getDriver()
    {
        return $this->whichOneof("driver");
    }

}

