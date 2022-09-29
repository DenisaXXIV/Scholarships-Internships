public void levelOrder() {
        levelOrder(root);
    }

    public void levelOrder(Node<T> node) {
        for (int i = 1; i <= maxDepth(node); i++) {
            printCurrentLevel(node, i);
        }
    }