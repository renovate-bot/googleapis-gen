# -*- coding: utf-8 -*-
# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#
import proto  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.speech.v1',
    manifest={
        'CustomClass',
        'PhraseSet',
        'SpeechAdaptation',
    },
)


class CustomClass(proto.Message):
    r"""A set of words or phrases that represents a common concept
    likely to appear in your audio, for example a list of passenger
    ship names. CustomClass items can be substituted into
    placeholders that you set in PhraseSet phrases.

    Attributes:
        name (str):
            The resource name of the custom class.
        custom_class_id (str):
            If this custom class is a resource, the custom_class_id is
            the resource id of the CustomClass. Case sensitive.
        items (Sequence[google.cloud.speech_v1.types.CustomClass.ClassItem]):
            A collection of class items.
    """

    class ClassItem(proto.Message):
        r"""An item of the class.

        Attributes:
            value (str):
                The class item's value.
        """

        value = proto.Field(
            proto.STRING,
            number=1,
        )

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    custom_class_id = proto.Field(
        proto.STRING,
        number=2,
    )
    items = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message=ClassItem,
    )


class PhraseSet(proto.Message):
    r"""Provides "hints" to the speech recognizer to favor specific
    words and phrases in the results.

    Attributes:
        name (str):
            The resource name of the phrase set.
        phrases (Sequence[google.cloud.speech_v1.types.PhraseSet.Phrase]):
            A list of word and phrases.
        boost (float):
            Hint Boost. Positive value will increase the probability
            that a specific phrase will be recognized over other similar
            sounding phrases. The higher the boost, the higher the
            chance of false positive recognition as well. Negative boost
            values would correspond to anti-biasing. Anti-biasing is not
            enabled, so negative boost will simply be ignored. Though
            ``boost`` can accept a wide range of positive values, most
            use cases are best served with values between 0 (exclusive)
            and 20. We recommend using a binary search approach to
            finding the optimal value for your use case. Speech
            recognition will skip PhraseSets with a boost value of 0.
    """

    class Phrase(proto.Message):
        r"""A phrases containing words and phrase "hints" so that the speech
        recognition is more likely to recognize them. This can be used to
        improve the accuracy for specific words and phrases, for example, if
        specific commands are typically spoken by the user. This can also be
        used to add additional words to the vocabulary of the recognizer.
        See `usage
        limits <https://cloud.google.com/speech-to-text/quotas#content>`__.

        List items can also include pre-built or custom classes containing
        groups of words that represent common concepts that occur in natural
        language. For example, rather than providing a phrase hint for every
        month of the year (e.g. "i was born in january", "i was born in
        febuary", ...), use the pre-built ``$MONTH`` class improves the
        likelihood of correctly transcribing audio that includes months
        (e.g. "i was born in $month"). To refer to pre-built classes, use
        the class' symbol prepended with ``$`` e.g. ``$MONTH``. To refer to
        custom classes that were defined inline in the request, set the
        class's ``custom_class_id`` to a string unique to all class
        resources and inline classes. Then use the class' id wrapped in
        $\ ``{...}`` e.g. "${my-months}". To refer to custom classes
        resources, use the class' id wrapped in ``${}`` (e.g.
        ``${my-months}``).

        Speech-to-Text supports three locations: ``global``, ``us`` (US
        North America), and ``eu`` (Europe). If you are calling the
        ``speech.googleapis.com`` endpoint, use the ``global`` location. To
        specify a region, use a `regional
        endpoint </speech-to-text/docs/endpoints>`__ with matching ``us`` or
        ``eu`` location value.

        Attributes:
            value (str):
                The phrase itself.
            boost (float):
                Hint Boost. Overrides the boost set at the phrase set level.
                Positive value will increase the probability that a specific
                phrase will be recognized over other similar sounding
                phrases. The higher the boost, the higher the chance of
                false positive recognition as well. Negative boost will
                simply be ignored. Though ``boost`` can accept a wide range
                of positive values, most use cases are best served with
                values between 0 and 20. We recommend using a binary search
                approach to finding the optimal value for your use case.
                Speech recognition will skip PhraseSets with a boost value
                of 0.
        """

        value = proto.Field(
            proto.STRING,
            number=1,
        )
        boost = proto.Field(
            proto.FLOAT,
            number=2,
        )

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    phrases = proto.RepeatedField(
        proto.MESSAGE,
        number=2,
        message=Phrase,
    )
    boost = proto.Field(
        proto.FLOAT,
        number=4,
    )


class SpeechAdaptation(proto.Message):
    r"""Speech adaptation configuration.

    Attributes:
        phrase_sets (Sequence[google.cloud.speech_v1.types.PhraseSet]):
            A collection of phrase sets. To specify the hints inline,
            leave the phrase set's ``name`` blank and fill in the rest
            of its fields. Any phrase set can use any custom class.
        phrase_set_references (Sequence[str]):
            A collection of phrase set resource names to
            use.
        custom_classes (Sequence[google.cloud.speech_v1.types.CustomClass]):
            A collection of custom classes. To specify the classes
            inline, leave the class' ``name`` blank and fill in the rest
            of its fields, giving it a unique ``custom_class_id``. Refer
            to the inline defined class in phrase hints by its
            ``custom_class_id``.
    """

    phrase_sets = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='PhraseSet',
    )
    phrase_set_references = proto.RepeatedField(
        proto.STRING,
        number=2,
    )
    custom_classes = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message='CustomClass',
    )


__all__ = tuple(sorted(__protobuf__.manifest))
