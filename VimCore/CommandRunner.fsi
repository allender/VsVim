﻿#light

namespace Vim
open Microsoft.VisualStudio.Text
open Microsoft.VisualStudio.Text.Operations
open Microsoft.VisualStudio.Text.Editor
open Vim

type internal CommandRunner =
    interface ICommandRunner
    new : ITextView * IRegisterMap * IMotionCapture * ITextViewMotionUtil * ICommandUtil * IStatusUtil * VisualKind-> CommandRunner

