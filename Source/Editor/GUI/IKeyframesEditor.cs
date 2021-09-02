// Copyright (c) 2012-2021 Wojciech Figat. All rights reserved.

using FlaxEngine;
using FlaxEngine.GUI;

namespace FlaxEditor.GUI
{
    /// <summary>
    /// Interface for keyframes/curves editors.
    /// </summary>
    public interface IKeyframesEditor
    {
        /// <summary>
        /// Gets or sets the keyframes editor collection used by this editor.
        /// </summary>
        IKeyframesEditorContext KeyframesEditorContext { get; set; }

        /// <summary>
        /// Called when keyframes selection should be cleared for editor.
        /// </summary>
        /// <param name="editor">The source editor.</param>
        void OnKeyframesDeselect(IKeyframesEditor editor);

        /// <summary>
        /// Called when keyframes selection rectangle gets updated.
        /// </summary>
        /// <param name="editor">The source editor.</param>
        /// <param name="control">The source selection control.</param>
        /// <param name="selection">The source selection rectangle (in source control local space).</param>
        void OnKeyframesSelection(IKeyframesEditor editor, ContainerControl control, Rectangle selection);

        /// <summary>
        /// Called to calculate the total amount of selected keyframes in the editor.
        /// </summary>
        /// <returns>The selected keyframes amount.</returns>
        int OnKeyframesSelectionCount();

        /// <summary>
        /// Called when keyframes selection should be deleted for all editors.
        /// </summary>
        /// <param name="editor">The source editor.</param>
        void OnKeyframesDelete(IKeyframesEditor editor);

        /// <summary>
        /// Called when keyframes selection should be moved.
        /// </summary>
        /// <param name="editor">The source editor.</param>
        /// <param name="control">The source movement control.</param>
        /// <param name="location">The source movement location (in source control local space).</param>
        /// <param name="start">The movement start flag.</param>
        /// <param name="end">The movement end flag.</param>
        void OnKeyframesMove(IKeyframesEditor editor, ContainerControl control, Vector2 location, bool start, bool end);

        /// <summary>
        /// Called when keyframes selection should be copied.
        /// </summary>
        /// <param name="editor">The source editor.</param>
        /// <param name="timeOffset">The additional time offset to apply to the copied keyframes (optional).</param>
        /// <param name="data">The result copy data text stream.</param>
        void OnKeyframesCopy(IKeyframesEditor editor, float? timeOffset, System.Text.StringBuilder data);

        /// <summary>
        /// Called when keyframes should be pasted (from clipboard).
        /// </summary>
        /// <param name="editor">The source editor.</param>
        /// <param name="timeOffset">The additional time offset to apply to the pasted keyframes (optional).</param>
        /// <param name="datas">The pasted data text.</param>
        /// <param name="index">The counter for the current data index. Set to -1 until the calling editor starts paste operation.</param>
        void OnKeyframesPaste(IKeyframesEditor editor, float? timeOffset, string[] datas, ref int index);
    }
}