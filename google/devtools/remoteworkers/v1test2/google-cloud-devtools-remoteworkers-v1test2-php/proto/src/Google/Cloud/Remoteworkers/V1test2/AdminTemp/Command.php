<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/remoteworkers/v1test2/bots.proto

namespace Google\Cloud\Remoteworkers\V1test2\AdminTemp;

use UnexpectedValueException;

/**
 * Possible administration actions.
 *
 * Protobuf type <code>google.devtools.remoteworkers.v1test2.AdminTemp.Command</code>
 */
class Command
{
    /**
     * Illegal value.
     *
     * Generated from protobuf enum <code>UNSPECIFIED = 0;</code>
     */
    const UNSPECIFIED = 0;
    /**
     * Download and run a new version of the bot. `arg` will be a resource
     * accessible via `ByteStream.Read` to obtain the new bot code.
     *
     * Generated from protobuf enum <code>BOT_UPDATE = 1;</code>
     */
    const BOT_UPDATE = 1;
    /**
     * Restart the bot without downloading a new version. `arg` will be a
     * message to log.
     *
     * Generated from protobuf enum <code>BOT_RESTART = 2;</code>
     */
    const BOT_RESTART = 2;
    /**
     * Shut down the bot. `arg` will be a task resource name (similar to those
     * in tasks.proto) that the bot can use to tell the server that it is
     * terminating.
     *
     * Generated from protobuf enum <code>BOT_TERMINATE = 3;</code>
     */
    const BOT_TERMINATE = 3;
    /**
     * Restart the host computer. `arg` will be a message to log.
     *
     * Generated from protobuf enum <code>HOST_RESTART = 4;</code>
     */
    const HOST_RESTART = 4;

    private static $valueToName = [
        self::UNSPECIFIED => 'UNSPECIFIED',
        self::BOT_UPDATE => 'BOT_UPDATE',
        self::BOT_RESTART => 'BOT_RESTART',
        self::BOT_TERMINATE => 'BOT_TERMINATE',
        self::HOST_RESTART => 'HOST_RESTART',
    ];

    public static function name($value)
    {
        if (!isset(self::$valueToName[$value])) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no name defined for value %s', __CLASS__, $value));
        }
        return self::$valueToName[$value];
    }


    public static function value($name)
    {
        $const = __CLASS__ . '::' . strtoupper($name);
        if (!defined($const)) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no value defined for name %s', __CLASS__, $name));
        }
        return constant($const);
    }
}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(Command::class, \Google\Cloud\Remoteworkers\V1test2\AdminTemp_Command::class);

